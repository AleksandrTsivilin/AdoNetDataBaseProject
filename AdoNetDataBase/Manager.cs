using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDataBase
{
    public class Manager:IDisposable
    {
        private readonly string _connectString = @"Data Source=DESKTOP-ABUB89D\SQLEXPRESS;Initial Catalog=Shop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private SqlConnection _connection;        
        private List<string> _tableNames;
        private string _currentTable;     
            

       

        public bool Connect()
        {
            try
            {
                _connection = new SqlConnection(_connectString);

            }
            catch
            {
                return false;
            }

            _connection.Open();
            return true;
        }                      

        public List<string> GetTableNames()
        {
            var commandText = $"SELECT [name] FROM sys.Tables";
            var command = GetCommand(commandText);
            using (var reader = command.ExecuteReader())
            {
                _tableNames = new List<string>();
                while (reader.Read())
                {
                    _tableNames.Add(reader[0].ToString());
                }                
                return _tableNames;
            }

        }

        public IEnumerable<TableInfo> GetCurrentTable(int index)
        {
            _currentTable = _tableNames[index];
            //создать объект необходимого типа

            return new List<TableInfo>();
        }              

        private SqlCommand GetCommand(string command)
        {
            return new SqlCommand(command, _connection);
        }

        public void Dispose()
        {
            _connection?.Dispose();
        }

        
       
    }
}
