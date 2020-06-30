using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperDemo.Services
{
    public interface IBaseService<T, TKey> 
    {
        T Get(TKey id);

        IEnumerable<T> GetList();
    }
}
