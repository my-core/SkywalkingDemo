using FastNet.Framework.Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SkywalkingDemo.Repository
{
    public class TestRepository : SqlServerRepository
    {
        public TestRepository(string connString)
            : base(connString)
        {

        }
    }
}
