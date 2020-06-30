using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DapperDemo.DapperService
{
    public class BaseRepository : IDisposable
    {
        public static IConfigurationRoot Configuration { get; set; }

        public static MySqlConnection conn;

        public static MySqlConnection GetMySqlConnection(bool open = true,bool convertZeroDatetime = false, bool allowZeroDatetime = false)
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
            var cs = builder.GetSection("ConnectionStrings:OilcenterDB").Value;
            var csb = new MySqlConnectionStringBuilder(cs)
            {
                AllowZeroDateTime = allowZeroDatetime,
                ConvertZeroDateTime = convertZeroDatetime
            };
            conn = new MySqlConnection(csb.ConnectionString);
            return conn;
        }

        public void Dispose()
        {
            if (conn != null && conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Close();
            }
        }
    }
}
