using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Auditing;
using Abp.Authorization;
using Abp.Runtime.Validation;
using Abp.Web.Models;
using KuMaDaoCoreAbp.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace KuMaDaoCoreAbp.Web.Mvc.Areas.Apis.Controllers
{
    [Area("Apis")]
    [Route("apis/[controller]")]

    [AbpAllowAnonymous] //禁用授权
    [DontWrapResult] //不要响应结果的包装
    [DisableValidation]  //不要 valid
    [DisableAuditing]  //不要审计日志
    [IgnoreAntiforgeryToken]  //跨站伪造 控制toekn验证
    public class QiniuController : KuMaDaoCoreAbpControllerBase
    {
        public IActionResult Index()
        {
            return Json(new { test="1"} );
        }

        public IActionResult GetToken(string bucket)
        {
            return Json(new { test = "1" });
        }
    }
}