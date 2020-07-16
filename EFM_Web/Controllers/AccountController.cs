using Deveplex.Web;
using EFM.Models;
using EFM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;

namespace EFM.Web.Mvc
{
    [RoutePrefix("uac")]
    [Route("{action}")]
    public class AccountController : AnonymousController
    {
        // GET: Account
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginRequest request, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                //if (ValidateUser(model.UserName, model.Password))
                if (request.LoginName.ToLower() == "admin")
                {
                    AuthenticationUserInfo authUserInfo = new AuthenticationUserInfo()//GetuserInfo(model.UserName);
                    {
                        ID = "123456789",
                        UID = "",
                        UserName = "张三",
                        Roles = "",
                    };
                    //if (userInfo.RoleName.ToLower() == "admin")
                    //{
                    //    role = "Admin";
                    //}

                    SecurityAuthentication.SetFormsAuthenticationTicket<AuthenticationUserInfo>(authUserInfo.ID, authUserInfo, TimeSpan.FromMinutes(20), true);

                    if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                        && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                    {
                        return new RedirectResult(returnUrl);
                    }
                    else
                    {
                        return new RedirectResult("~/");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "The user name or password provided is incorrect.");
                }
            }
            return View(request);
        }
        public ActionResult ResetPassword()
        {
            return View();
        }

        [EFMAuthorize]
        public ActionResult ChangePassword()
        {
            return View();
        }
    }
}