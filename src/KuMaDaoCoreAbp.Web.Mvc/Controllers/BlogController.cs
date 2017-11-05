using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KuMaDaoCoreAbp.Controllers;


namespace KuMaDaoCoreAbp.Web.Controllers
{
    public class BlogController : KuMaDaoCoreAbpControllerBase
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Detail()
        {
            return View();
        }
    }
}
