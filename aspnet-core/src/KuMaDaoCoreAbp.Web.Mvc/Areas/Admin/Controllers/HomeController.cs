using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KuMaDaoCoreAbp.Controllers;
using Abp.AspNetCore.Mvc.Authorization;

namespace KuMaDaoCoreAbp.Web.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AbpMvcAuthorize]
    public class HomeController : KuMaDaoCoreAbpControllerBase
    {
        
        public ActionResult Index()
        {
            return View();
        }
    }
}