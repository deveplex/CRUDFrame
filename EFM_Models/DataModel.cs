using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFM.Models
{
    public class DataModel : IDataModel
    {
        protected virtual string HashString()
        {
            return null;
        }

        public string GetHashKey()
        {
            string hashString = HashString();

            if (string.IsNullOrEmpty(hashString))
                return null;

            return hashString;
        }
    }
}
