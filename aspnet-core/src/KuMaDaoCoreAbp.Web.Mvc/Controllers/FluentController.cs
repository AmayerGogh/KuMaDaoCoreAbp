using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KuMaDaoCoreAbp.Controllers;

namespace KuMaDaoCoreAbp.Web.Mvc.Controllers
{
    public class FluentController : KuMaDaoCoreAbpControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}