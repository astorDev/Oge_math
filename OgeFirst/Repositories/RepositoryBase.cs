using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OgeFirst.Repositories
{
    public abstract class RepositoryBase
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["gearhost"].ConnectionString;

        protected static object Perform(Func<SqlConnection, object> action)
        {
            var connection = GetOpenConnection();
            var result = action(connection);
            Shut(connection);
            return result;
        }

        protected static object Perform(Func<SqlConnection, int, object> action, int id)
        {
            var connection = GetOpenConnection();
            var result = action(connection, id);
            Shut(connection);
            return result;
        }

        protected static object Perform(Func<SqlConnection, object, object> action, object props)
        {
            var connection = GetOpenConnection();
            var result = action(connection, props);
            Shut(connection);
            return result;
        }

        private static SqlConnection GetOpenConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }

        private static void Shut(SqlConnection connection)
        {
            connection.Close();
            connection.Dispose();
        }

        protected static SqlDataReader GetReader(string query, SqlConnection connection)
        {
            SqlCommand command = new SqlCommand(query, connection);
            return command.ExecuteReader();
        }
    }
}