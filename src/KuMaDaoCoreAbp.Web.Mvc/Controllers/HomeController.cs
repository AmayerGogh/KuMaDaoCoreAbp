﻿using Abp.AspNetCore.Mvc.Authorization;
using KuMaDaoCoreAbp.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace KuMaDaoCoreAbp.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : KuMaDaoCoreAbpControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}