using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KuMaDaoCoreAbp.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace KuMaDaoCoreAbp.Web.Mvc.Controllers
{
    public class AccountController : KuMaDaoCoreAbpControllerBase
    {
        public IActionResult Login()
        {
           
            return Redirect("/admin/account/login");
        }
    }
}