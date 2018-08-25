using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KuMaDaoCoreAbp.Web.Areas.Apis.Models
{
    public class ApiBaseCommon
    {
        public ApiCode Code { get; set; } 
        public string ErrMsg { get; set; }
        public string[] Data { get; set; }
    }

    public enum ApiCode
    {
        正确=200,
        未知异常=10000,
        上传失败 =10001

    }
}
 