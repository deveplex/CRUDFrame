using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFM.Models
{
    public class MenuInfo
    {
        public string MenuName { get; set; }
        public string MvcUrl { get; set; }
        public string WebUrl { get; set; }
        public string WinForm { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
