using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DapperDemo.Data
{
    public interface IDbFactory
    {
        IDbConnection Create();
    }
}
