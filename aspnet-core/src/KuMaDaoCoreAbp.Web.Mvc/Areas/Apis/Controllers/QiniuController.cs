using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Auditing;
using Abp.Authorization;
using Abp.Runtime.Validation;
using Abp.Web.Models;
using Amayer.Modules.Qiniu;
using KuMaDaoCoreAbp.Controllers;
using KuMaDaoCoreAbp.Web.Areas.Apis.Models;
using Microsoft.AspNetCore.Mvc;

namespace KuMaDaoCoreAbp.Web.Mvc.Areas.Apis.Controllers
{
    [Area("Apis")]
    [Route("apis/[controller]/[action]/{id?}")]

    [AbpAllowAnonymous] //禁用授权
    [DontWrapResult] //不要响应结果的包装
    [DisableValidation]  //不要 valid
    [DisableAuditing]  //不要审计日志
    [IgnoreAntiforgeryToken]  //跨站伪造 控制toekn验证
    public class QiniuController : KuMaDaoCoreAbpControllerBase
    {
        [Obsolete]
        public IActionResult Index()
        {
            return Json(new { test="1"} );
        }
        [Obsolete]
       
        public IActionResult GetToken(string bucket)
        {
            return Json(new { test = "1" });
        }
        [Obsolete]
        public IActionResult UploadBase64([FromBody]UoloadModel model)
        {
            try
            {             
                model.msg = model.msg.Replace("data:image/png;base64,", string.Empty);
                var array = Convert.FromBase64String(model.msg);
                Upload upload = new Upload();
                var res =  upload.UploadData(array);
                return Json(res);
            }
            catch (Exception ex)
            {

                return Json(new ApiBaseCommon { Code = ApiCode.未知异常,ErrMsg=ex.ToString() });
            }
            //return Json(new ApiBaseCommon { Code = ApiCode.正确 });
        }
    }
}