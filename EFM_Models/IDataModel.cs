using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFM.Models
{
    public interface IDataModel
    {
        string GetHashKey();
    }
}