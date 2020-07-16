using Deveplex.Web;
using EFM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace EFM.Web.Mvc
{
    public class EFMAuthorizeAttribute : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext.User.Identity.IsAuthenticated)
            {
                AuthenticationUserInfo authUserInfo = SecurityAuthentication.GetFormsAuthenticationTicket<AuthenticationUserInfo>("authUserInfo.ID");
                if (authUserInfo == null)
                {
                    return false;
                }
                #region mm
                //                ApplicationSignInManager SignInManager = httpContext.GetOwinContext().Get<ApplicationSignInManager>();
                //                ApplicationUserManager UserManager = httpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
                //                string appid = string.Empty;
                //                string secret = string.Empty;


                //                appid = WxPayConfig.APPID;
                //                secret = WxPayConfig.APPSECRET;

                //                var code = httpContext.Request["Code"];
                //                string returnUrl = System.Web.HttpUtility.UrlDecode(httpContext.Request["ReturnUrl"] ?? "/");


                //                if (string.IsNullOrEmpty(code))
                //                {
                //                    string host = httpContext.Request.Url.Host;
                //                    string path = httpContext.Request.Path;
                //                    string redirectUrl = "http://" + host + path + "?ReturnUrl=" + System.Web.HttpUtility.UrlEncode(returnUrl);//重定向的url，这里不需要进行编码，在后面会自己编码
                //                    try
                //                    {
                //                        //todo:通过微信获取2.0授权的url
                //                        string url = Wechat.AuthorizeUrl(appid, redirectUrl, "state", "snsapi_base");

                //                        httpContext.Response.Redirect(url);
                //                    }
                //                    catch (System.Exception ex)
                //                    {
                //#if DEBUG
                //                        httpContext.Response.Write("构造网页授权获取code的URL时出错，错误是：" + ex.Message);
                //                        httpContext.Response.End();
                //#endif
                //                    }
                //                }
                //                else
                //                {
                //                    var client = new System.Net.WebClient();
                //                    client.Encoding = System.Text.Encoding.UTF8;
                //                    string url = Wechat.AccessTokenUrl(appid, secret, code);
                //                    var data = client.DownloadString(url);
                //                    var obj = JsonConvert.DeserializeObject<Dictionary<string, string>>(data);
                //                    string accessToken;
                //                    if (!obj.TryGetValue("access_token", out accessToken))
                //                    {
                //#if DEBUG
                //                        httpContext.Response.Write("构造网页授权获取access_token的URL时出错");
                //                        httpContext.Response.End();
                //#endif
                //                    }
                //                    var openid = obj["openid"];
                //                    Utils.WidgetCode.ServerInfo.SetCookies("WXopenid", openid, DateTime.MinValue);

                //                    var existUser = UserManager.Users.FirstOrDefault(p => p.OpenId == openid);
                //                    if (existUser != null)
                //                    {
                //                        SignInManager.SignInAsync(existUser, false, false);
                //                        httpContext.Response.Redirect(returnUrl);
                //                    }
                //                }
                #endregion
                return true;
            }
            return false;
        }

        //public override void OnAuthorization(AuthorizationContext filterContext)
        //{
        //    base.OnAuthorization(filterContext);
        //    if (filterContext.HttpContext.Response.StatusCode == 401)
        //    {
        //        filterContext.Result = new RedirectResult("/403.htm");//跳转异常页面
        //    }
        //}

    }
}
