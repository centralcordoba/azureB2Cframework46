using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OpenIdConnect;
using Owin;
using System.Configuration;

public class Startup
{
    public void Configuration(IAppBuilder app)
    {
        app.SetDefaultSignInAsAuthenticationType(CookieAuthenticationDefaults.AuthenticationType);
        app.UseCookieAuthentication(new CookieAuthenticationOptions());
        //app.SetDefaultSignInAsAuthenticationType(CookieAuthenticationDefaults.AuthenticationType);

        //app.UseCookieAuthentication(new CookieAuthenticationOptions());
        //var Authority1 = $"https://{ConfigurationManager.AppSettings["ida:Tenant"]}.b2clogin.com/tfp/{ConfigurationManager.AppSettings["ida:Tenant"]}.onmicrosoft.com/{ConfigurationManager.AppSettings["ida:SignUpSignInPolicyId"]}/v2.0/";

        //app.UseOpenIdConnectAuthentication(new OpenIdConnectAuthenticationOptions
        //{
        //    ClientId = ConfigurationManager.AppSettings["ida:ClientId"],
        //    Authority = $"https://{ConfigurationManager.AppSettings["ida:Tenant"]}.b2clogin.com/tfp/{ConfigurationManager.AppSettings["ida:Tenant"]}.onmicrosoft.com/{ConfigurationManager.AppSettings["ida:SignUpSignInPolicyId"]}/v2.0/",
        //    RedirectUri = ConfigurationManager.AppSettings["ida:RedirectUri"],
        //    PostLogoutRedirectUri = ConfigurationManager.AppSettings["ida:RedirectUri"],
        //    ClientSecret = ConfigurationManager.AppSettings["ida:ClientSecret"],
        //    ResponseType = "id_token",
        //    Scope = "openid",
        //    TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
        //    {
        //        NameClaimType = "name"
        //    }
        //});
    }
}