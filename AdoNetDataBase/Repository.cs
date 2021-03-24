using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AdoNetDataBase
{
    public class Repository<T> : IRepository<T>,IDisposable where T:new ()
    {

        private SqlConnection _connection;
        private readonly string _tableName = $"[{typeof(T).Name}]";

        public Repository(SqlConnection connection)
        {
            _connection = connection;
        }       

        public void Dispose()
        {
            _connection?.Dispose();
        }

        public IEnumerable<T> Get()
        {
            var results = new List<T>();
            var commandText = $"SELECT * FROM {_tableName}";
            var command = GetCommand(commandText);

            using (var reader = command.ExecuteReader())
            {
                //var schema = reader.GetColumnsSchema();
                
                return results;
            }
        }       

        private SqlCommand GetCommand(string command)
        {
            return new SqlCommand(command, _connection);
        }

        
    }
}
