using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFM
{
    using dd = System.Tuple;
}

namespace EFM.ViewModels
{
    public class LoginRequest
    {
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string ValidCode { get; set; }
        public bool IsRemember { get; set; }

    }
}
