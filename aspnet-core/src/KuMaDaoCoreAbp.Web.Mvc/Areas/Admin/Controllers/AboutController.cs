using Abp.AspNetCore.Mvc.Authorization;
using KuMaDaoCoreAbp.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace KuMaDaoCoreAbp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AbpMvcAuthorize]
    public class AboutController : KuMaDaoCoreAbpControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}