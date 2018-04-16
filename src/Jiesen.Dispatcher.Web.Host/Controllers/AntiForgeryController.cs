using Microsoft.AspNetCore.Antiforgery;
using Jiesen.Dispatcher.Controllers;

namespace Jiesen.Dispatcher.Web.Host.Controllers
{
    public class AntiForgeryController : DispatcherControllerBase
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
