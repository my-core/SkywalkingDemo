using FastNet.Framework.Dapper;
using FastNet.Framework.Dapper.Generator;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SkywalkingDemo.Repository
{
    /// <summary>
    /// 实现MySql驱动仓储
    /// </summary>
    public class MySqlRepository : BaseRepository, IBaseRepository
    {
        private string _connString { get; set; }
        public MySqlRepository(string connString)
            : base(connString, new MySqlGenerator())
        {
            _connString = connString;
        }
        /// <summary>
        /// OpenConnection
        /// </summary>
        /// <returns></returns>
        public override IDbConnection OpenConnection()
        {
            var conn = new MySqlConnection(_connString);
            conn.Open();
            return conn;
        }
    }
}
