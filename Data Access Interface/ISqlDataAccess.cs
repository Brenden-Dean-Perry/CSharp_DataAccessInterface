using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessInterface
{
    public interface ISqlDataAccess
    {
        Task<IEnumerable<R>> LoadDataAsync<R, P>(string Query, P Parameters, string ConnectionId = "Default", int? CommandTimeout = null);
        Task<R> LoadDataAsync_SingleRecord<R, P>(string Query, P Parameters, string ConnectionId = "Default", int? CommandTimeout = null);
        Task<int> SaveDataAsync<P>(string Query, P Parameters, string ConnectionId = "Default", int? CommandTimeout = null);
        IEnumerable<R> LoadData<R, P>(string Query, P Parameters, string ConnectionId = "Default", int? CommandTimeout = null);
        IEnumerable<R> LoadData<R>(string Query, string ConnectionId = "Default", int? CommandTimeout = null);
        R LoadData_SingleRecord<R, P>(string Query, P Parameters, string ConnectionId = "Default", int? CommandTimeout = null);
        int SaveData<P>(string Query, IEnumerable<P> Parameters, string ConnectionId = "Default", int? CommandTimeout = null);
        int SaveData<P>(string Query, P Parameters, string ConnectionId = "Default", int? CommandTimeout = null);

    }
}
