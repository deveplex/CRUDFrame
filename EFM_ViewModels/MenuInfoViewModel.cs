using EFM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFM.ViewModels
{
   public class MenuInfoViewModel : ViewModel
    {
        public string MenuName { get; set; }
        public string MvcUrl { get; set; }
        public string WebUrl { get; set; }
    }



}
