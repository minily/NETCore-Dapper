using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperDemo.Data
{
    public class DbOption
    {
        public string ConnectionString { get; set; }

        public DbModel DbModel { get; set; }
    }


    public enum DbModel
    {
        MySQL = 0,
        SQLServer = 1,
        Oracle = 2
    }
}
