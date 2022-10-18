using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Repository.Dapper_Repository.Interface
{
    public interface IDbRepo
    {
        Task<T> GetAsync<T>(string command, object parms);
        Task<List<T>> GetAll<T>(string command, object parms);
        Task<int> EditData(string command, object parms);
    }
}
