using DapperDemo.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DapperDemo.Services
{
    public class BaseService<T, TKey> : IBaseService<T, TKey> where T : class
    {
        private readonly IDbFactory _dbFactory;

        protected IDbConnection _dbConnection;

        public BaseService(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
            _dbConnection = _dbFactory.Create();
        }

        public T Get(TKey id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
