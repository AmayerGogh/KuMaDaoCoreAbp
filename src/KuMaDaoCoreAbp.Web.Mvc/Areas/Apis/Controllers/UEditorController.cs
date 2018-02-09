using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Auditing;
using Abp.Authorization;
using Abp.Domain.Uow;
using Abp.Runtime.Validation;
using Abp.Web.Models;
using Amayer.Modules.Ueditor;
using KuMaDaoCoreAbp.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace KuMaDaoCoreAbp.Web.Mvc.Areas.Apis.Controllers
{
    [Area("Apis")]
    [Route("apis/[controller]")]
    
    [AbpAllowAnonymous]
    [DontWrapResult]
    [DisableValidation]
    [DisableAuditing]
    public class UEditorController : KuMaDaoCoreAbpControllerBase
    {
        private UEditorService ue;

        public UEditorController(UEditorService ue)
        {
            this.ue = ue;          
            this.UnitOfWorkManager = null;
        }

        public void Do()
        {

            ue.DoAction(HttpContext);
        }
        //[DontWrapResult]
        //[DisableAuditing]
        //[DisableValidation]
        //
        //public ActionResult Index()
        //{
        //    //context.Request.Query["action"];
        //    var s = HttpContext.Request.Query["action"].ToString();
        //    Ueditor u = new Ueditor(HttpContext, s);
        //    // return View();
        //    //return Json();
        //    return Ok();
        //}



    }
}