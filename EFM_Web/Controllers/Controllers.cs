using EFM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Security;

namespace EFM.Web.Mvc
{
    public class BaseController : Controller
    {
    }

    [AllowAnonymous]
    public class AnonymousController : BaseController
    {
    }

    [EFMAuthorize]
    public class AuthorizeController : BaseController
    {
    }


}
