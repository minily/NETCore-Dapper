using DapperDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperDemo.Services
{
    public interface IOilFillTypeService
    {
        List<oil_filltype> List();
    }
}
