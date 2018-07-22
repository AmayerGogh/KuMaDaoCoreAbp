using Abp.AspNetCore.Mvc.Authorization;
using Abp.Auditing;
using Abp.Authorization;
using KuMaDaoCoreAbp.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace KuMaDaoCoreAbp.Web.Controllers
{
    //[AbpMvcAuthorize]
    [DisableAuditing]
    [AbpAllowAnonymous]
    public class HomeController : KuMaDaoCoreAbpControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}