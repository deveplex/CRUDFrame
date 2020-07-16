using EFM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFM.BLL
{
    /// <summary>
    /// 业务基类对象
    /// </summary>
    /// <typeparam name="T">业务对象类型</typeparam>
    public class BaseBLL<T> where T : DataModel, new()
    {

        /// <summary>
        /// 插入指定对象到数据库中
        /// </summary>
        /// <param name="obj">指定的对象</param>
        /// <returns>执行操作是否成功。</returns>
        public virtual bool Insert(T obj)
        {
            return false;//baseDal.Insert(obj);
        }
    }
}
