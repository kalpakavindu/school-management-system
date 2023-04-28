using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_management_system
{
    internal class Functions
    {
        private SqlConnection _connection;
        private SqlCommand _command;
        private DataTable _dataTable;
        private SqlDataAdapter _dataAdapter;
        private string _connectionString;

        public Functions()
        {
            _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Kalpa Kavindu\Documents\SchoolManagementSystem_DotNET_DB.mdf"";Integrated Security=True;Connect Timeout=30";
            _connection = new SqlConnection(_connectionString);
            _command = new SqlCommand();
            _command.Connection = _connection;
        }

        public DataTable GetData(string query)
        {
            _dataTable = new DataTable();
            _dataAdapter = new SqlDataAdapter(query,_connectionString);
            _dataAdapter.Fill(_dataTable);
            return _dataTable;
        }

        public int SetData(string query)
        {
            int cnt;
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
            _command.CommandText = query;
            cnt = _command.ExecuteNonQuery();

            return cnt;
        }
    }
}
