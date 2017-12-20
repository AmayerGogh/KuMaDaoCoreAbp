using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abp.Auditing;
using Microsoft.AspNetCore.Hosting;
using KuMaDaoCoreAbp.Controllers;

namespace KuMaDaoCoreAbp.Web.Mvc.Controllers
{
    public class ApplicationController : KuMaDaoCoreAbpControllerBase
    {
        private IHostingEnvironment host = null;
        public ApplicationController(IHostingEnvironment  host)
        {
            this.host = host;
        }
        [DisableAuditing]
        public IActionResult Admin()
        {          
            return File(System.IO.File.Open(host.WebRootPath +"/Angular/admin/dist/index.html", System.IO.FileMode.Open), "text/html");
        }
    }
}