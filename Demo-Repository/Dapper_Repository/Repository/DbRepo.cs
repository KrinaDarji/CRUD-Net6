using Dapper;
using Demo_Repository.Dapper_Repository.Interface;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Repository.Dapper_Repository.Repository
{
    public class DbRepo : IDbRepo
    {
        private readonly IDbConnection db;
        public DbRepo(IConfiguration configuration)
        {
            db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }

        public async Task<T> GetAsync<T>(string command, object parms)
        {
            T result;

            result = (await db.QueryAsync<T>(command, parms).ConfigureAwait(false)).FirstOrDefault();

            return result;

        }

        public async Task<List<T>> GetAll<T>(string command, object parms)
        {

            List<T> result = new List<T>();

            result = (await db.QueryAsync<T>(command, parms)).ToList();

            return result;
        }

        public async Task<int> EditData(string command, object parms)
        {
            int result;

            result = await db.ExecuteAsync(command, parms);

            return result;
        }
    }
}
