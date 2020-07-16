using Deveplex.Web;
using EFM.Models;
using EFM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFM.Web.Mvc
{
    public class MainController : AuthorizeController
    {
        public ActionResult Index()
        {
            return View();
        }
        [ChildActionOnly]
        public ActionResult Header()
        {
            AuthenticationUserInfo authUserInfo = SecurityAuthentication.GetFormsAuthenticationTicket<AuthenticationUserInfo>("authUserInfo.ID");

            IEnumerable<MenuInfoViewModel> mainMenuList = new List<MenuInfoViewModel>()
            {
                new MenuInfoViewModel() { MenuName="动态信息" },
                new MenuInfoViewModel() { MenuName="用户管理" },
                new MenuInfoViewModel() { MenuName="商品管理" },
                new MenuInfoViewModel() { MenuName="订单管理" },
                new MenuInfoViewModel() { MenuName="报表管理" },
                new MenuInfoViewModel() { MenuName="系统管理" }
            };
            return View(Tuple.Create(
                authUserInfo,  //Item1:AuthUserInfo
                mainMenuList  //Item2:MemuInfoList
               ));
        }

        [ChildActionOnly]
        public ActionResult Footer()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [AllowAnonymous]
        public ActionResult Init()
        {
            return View();
        }
    }
}