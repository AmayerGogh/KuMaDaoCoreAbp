using Abp.AspNetCore.Mvc.Authorization;
using Abp.Auditing;
using KuMaDaoCoreAbp.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace KuMaDaoCoreAbp.Web.Controllers
{
    //[AbpMvcAuthorize]
    [DisableAuditing]
    public class HomeController : KuMaDaoCoreAbpControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}