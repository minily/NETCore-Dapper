using Dapper;
using DapperDemo.Data;
using DapperDemo.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DapperDemo.Services
{
    public class OilFillTypeService : BaseService<oil_filltype, int>, IOilFillTypeService
    {

        private readonly IDbFactory _dbFactory;

        public OilFillTypeService(IDbFactory dbFactory) : base(dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public List<oil_filltype> List()
        {
            using (var conn = _dbFactory.Create())
            {
                var sql = "select * from oil_filltype";
                var list = conn.Query<oil_filltype>(sql).ToList();

                return list;
            }
        }
    }
}
