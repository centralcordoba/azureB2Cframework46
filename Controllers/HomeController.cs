using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OpenIdConnect;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationABC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public void SignIn()
        {
            //if (!Request.IsAuthenticated)
            //{
            //    HttpContext.GetOwinContext().Authentication.Challenge(
            //    new Microsoft.Owin.Security.AuthenticationProperties { RedirectUri = "/" },
            //    OpenIdConnectAuthenticationDefaults.AuthenticationType);
            //    ;
            //}
           
            Response.Redirect(ConfigurationManager.AppSettings["ExternalUrl"]);
        }

        public void SignOut()
        {
            HttpContext.GetOwinContext().Authentication.SignOut(
            new AuthenticationProperties { RedirectUri = "/" }, // Redirigir a la página principal o donde desees después del logout
            OpenIdConnectAuthenticationDefaults.AuthenticationType,
            CookieAuthenticationDefaults.AuthenticationType);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}