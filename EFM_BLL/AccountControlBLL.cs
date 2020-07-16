using EFM.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFM.BLL
{
   public static class AccountControlBLL
    {
        public static void Register()
        {
            EfmRepository efmRepository = new EfmRepository();
            string sql = @"";

            efmRepository.ExecuteQuery(sql, new { });
        }

        public static void Authorize()
        {
            EfmRepository efmRepository = new EfmRepository();
            string sql = @"

";

            efmRepository.ExecuteQuery(sql, new { });
        }
    }
}
