using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Auditing;
using Abp.Authorization;
using KuMaDaoCoreAbp.Controllers;
using Microsoft.AspNetCore.Mvc;
using UEditorNetCore;

namespace KuMaDaoCoreAbp.Web.Mvc.Areas.Apis.Controllers
{
    [Area("Apis")]
    [Route("apis/[controller]")]
    [DisableAuditing]
    [AbpAllowAnonymous]
    public class UEditorController : KuMaDaoCoreAbpControllerBase
    {
        private UEditorService ue;
     
        public UEditorController(UEditorService ue)
        {
            this.ue = ue;
        }

        public void Do()
        {
            ue.DoAction(HttpContext);
        }
        
    }
}