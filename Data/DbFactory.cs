
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DapperDemo.Data
{
    public class DbFactory : IDbFactory
    {
        private readonly IOptions<DbOption> _options;

        public DbFactory(IOptions<DbOption> options)
        {
            _options = options;
        }

        public IDbConnection Create()
        {
            IDbConnection conn = null;
            DbOption dbOption = _options.Value;
            switch (dbOption.DbModel)
            {
                case DbModel.MySQL:
                    conn = new MySqlConnection(dbOption.ConnectionString);

                    // 如果sql语句中有中括号，安装Dapper.SimpleCRUD，并加入下面这行代码可避免出错
                    // Dapper.SimpleCRUD.SetDialect(Dapper.SimpleCRUD.Dialect.MySQL);
                    break;
                case DbModel.SQLServer:
                    conn = new SqlConnection(dbOption.ConnectionString);
                    break;
                default:
                    throw new Exception("Please specify DbModel");
            }

            return conn;
        }
    }
}
