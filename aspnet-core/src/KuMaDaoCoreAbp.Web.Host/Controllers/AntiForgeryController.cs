using Microsoft.AspNetCore.Antiforgery;
using KuMaDaoCoreAbp.Controllers;

namespace KuMaDaoCoreAbp.Web.Host.Controllers
{
    public class AntiForgeryController : KuMaDaoCoreAbpControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
