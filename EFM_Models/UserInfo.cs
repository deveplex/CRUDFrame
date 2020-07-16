using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFM.Models
{
    public class UserInfo : DataModel
    {
        public string sgid { get; set; }
        public string suid { get; set; }
        public string veml { get; set; }
        public string vmbl { get; set; }
        public int type { get; set; }
        public int stat { get; set; }
        public DateTime? crdt { get; set; }
        public string hashkey { get; set; }

        protected override string HashString()
        {
            return suid + veml + vmbl + type + stat;

    }
}


    public class PwdInfo : DataModel
    {
        public string fk_sgid { get; set; }
        public string pswd { get; set; }
        public int fmat { get; set; }
        public string key { get; set; }
        public string hashkey { get; set; }

        protected override string HashString()
        {
            return fk_sgid + pswd + fmat + key;
        }
    }
}
