using Amayer.Express;
using Qiniu.Common;
using Qiniu.Http;
using Qiniu.IO;
using Qiniu.IO.Model;
using Qiniu.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Amayer.Modules.Qiniu
{
    // <summary>
    // https://developer.qiniu.com/kodo/sdk/4056/c-sdk-v7-2-15#4
    // </summary>
    public class Upload
    {

        public static HttpResult UploadFile()
        {
            var token = QiNiuHelper.GetToken();

            string saveKey = "1.png";
            string localFile = "D:\\QFL\\1.png";

            return new UploadManager().UploadFile(localFile, saveKey, token);
        }
        /// <summary>
        /// 上传（来自网络回复的）数据流
        /// </summary>
        public void UploadStream()
        {
            var token = QiNiuHelper.GetToken();
            try
            {
                string url = "http://img.ivsky.com/img/tupian/pre/201610/09/beifang_shanlin_xuejing-001.jpg";
                var wReq = System.Net.WebRequest.Create(url) as System.Net.HttpWebRequest;
                var resp = wReq.GetResponse() as System.Net.HttpWebResponse;
                using (var stream = resp.GetResponseStream())
                {
                    // 请不要使用UploadManager的UploadStream方法，因为此流不支持查找(无法获取Stream.Length)
                    // 请使用FormUploader或者ResumableUploader的UploadStream方法                 
                    var result = new FormUploader().UploadStream(stream, "xuejing-001.jpg", token);
                    Console.WriteLine(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public HttpResult UploadData(byte[] data, ref string url)
        {
            var token = QiNiuHelper.GetToken();
            var fileName = QiNiuHelper.GetNextFileName();
            url = QiNiuHelper.domain + fileName;
            // 生成上传凭证，参见
            // https://developer.qiniu.com/kodo/manual/upload-token            

            HttpResult result = new FormUploader().UploadData(data, fileName, token);
            return QiNiuHelper.UploadResult(result);
        }

        /// <summary>
        /// 上传大文件，可以从上次的断点位置继续上传
        /// </summary>
        public void UploadBigFile()
        {
            var token = QiNiuHelper.GetToken();


            string saveKey = "1.mp4";
            string localFile = "D:\\QFL\\1.mp4";
            // 断点记录文件，可以不用设置，让SDK自动生成，如果出现续上传的情况，SDK会尝试从该文件载入断点记录
            // 对于不同的上传任务，请使用不同的recordFile
            string recordFile = "D:\\QFL\\resume.12345";

            // 包含两个参数，并且都有默认值
            // 参数1(bool): uploadFromCDN是否从CDN加速上传，默认否
            // 参数2(enum): chunkUnit上传分片大小，可选值128KB,256KB,512KB,1024KB,2048KB,4096KB
            ResumableUploader ru = new ResumableUploader(false, ChunkUnit.U1024K);
            // ResumableUploader.UploadFile有多种形式，您可以根据需要来选择
            //
            // 最简模式，使用默认recordFile和默认uploadProgressHandler
            //UploadFile(localFile,saveKey,token)
            // 
            // 基本模式，使用默认uploadProgressHandler
            // UploadFile(localFile,saveKey,token,recordFile)
            //
            // 一般模式，使用自定义进度处理(可以监视上传进度)
            // UploadFile(localFile,saveKey,token,recordFile,uploadProgressHandler)
            //
            // 高级模式，包含上传控制(可控制暂停/继续 或者强制终止)
            // UploadFile(localFile,saveKey,token,recordFile,uploadProgressHandler,uploadController)
            // 
            // 支持自定义参数
            //var extra = new System.Collections.Generic.Dictionary<string, string>();
            //extra.Add("FileType", "UploadFromLocal");
            //extra.Add("YourKey", "YourValue");
            //uploadFile(...,extra,...)
            //最大尝试次数(有效值1~20)，在上传过程中(如mkblk或者bput操作)如果发生错误，它将自动重试，如果没有错误则无需重试
            int maxTry = 10;
            // 使用默认进度处理，使用自定义上传控制            
            UploadProgressHandler upph = new UploadProgressHandler(ResumableUploader.DefaultUploadProgressHandler);
            UploadController upctl = new UploadController(uploadControl);
            HttpResult result = ru.UploadFile(localFile, saveKey, token, recordFile, maxTry, upph, upctl);
            Console.WriteLine(result);
        }
        // 内部变量，仅作演示
        private bool paused = false;
        /// <summary>
        /// 上传控制
        /// </summary>
        /// <returns></returns>
        private UPTS uploadControl()
        {
            // 这个函数只是作为一个演示，实际当中请根据需要来设置
            // 这个演示的实际效果是“走走停停”，也就是停一下又继续，如此重复直至上传结束
            paused = !paused;
            if (paused)
            {
                return UPTS.Suspended;
            }
            else
            {
                return UPTS.Activated;
            }
        }


    }


    static class QiNiuHelper
    {
        static string AccessKey = "YjDHsgJaWptKG-b-deOi4miu-azbGk0uJ6jaPXjj";
        static string SecretKey = "WNJIIhoXW5XxLNniorm2TKsZayPoFRafE-iJt83o";
        public static string bucket = "amayercdn";
        public static string domain = "http://olyh26zl9.bkt.clouddn.com/";
        static QiNiuHelper()
        {
            Config.AutoZone(AccessKey, bucket, false);
        }
        public static string GetToken()
        {
            // 生成(上传)凭证时需要使用此Mac
            // 这个示例单独使用了一个Settings类，其中包含AccessKey和SecretKey
            // 实际应用中，请自行设置您的AccessKey和SecretKey
            Mac mac = new Mac(AccessKey, SecretKey);
            // 上传策略，参见 
            // https://developer.qiniu.com/kodo/manual/put-policy
            PutPolicy putPolicy = new PutPolicy();
            // 如果需要设置为"覆盖"上传(如果云端已有同名文件则覆盖)，请使用 SCOPE = "BUCKET:KEY"
            // putPolicy.Scope = bucket + ":" + saveKey;
            putPolicy.Scope = bucket;
            // 上传策略有效期(对应于生成的凭证的有效期)          
            putPolicy.SetExpires(3600);
            // 上传到云端多少天后自动删除该文件，如果不设置（即保持默认默认）则不删除
            putPolicy.DeleteAfterDays = 1;
            // 上传到云端多少天后自动删除该文件，如果不设置（即保持默认默认）则不删除           
            // 生成上传凭证，参见
            // https://developer.qiniu.com/kodo/manual/upload-token            
            string jstr = putPolicy.ToJsonString();
            AudoSetZone();
            return Auth.CreateUploadToken(mac, jstr);
        }
        public static HttpResult UploadResult(HttpResult res)
        {
            return res;
        }

        public static string GetNextFileName()
        {

            return TimestampID.GetInstance().Next(data =>
            {
                return data.ToString("yyyyMMddhhmmss");
            });

        }



        static void AudoSetZone(string bucket = "amayercdn")
        {
            Config.AutoZone(AccessKey, bucket, false);
        }

    }
    //public  class UploadFileResult
    //{

    //}

}
