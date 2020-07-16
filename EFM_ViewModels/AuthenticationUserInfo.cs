using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFM.ViewModels
{
    public class AuthenticationUserInfo: ViewModel
    {
        public string ID { get; set; }
        public string UID { get; set; }
        public string UserName { get; set; }
        public string Roles { get; set; }
    }
}
