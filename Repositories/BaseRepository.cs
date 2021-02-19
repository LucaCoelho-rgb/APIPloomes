using Dapper;
using Dapper.Contrib.Extensions;
using PloomesAPI.Model;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace PloomesAPI.Repositories
{
    public class BaseRepository
    {
        public static List<T> QuerySql<T>(string sql, object parameter = null)
        {
            List<T> resultado;
            using (var connection = new SqlConnection("Server = testeapi.database.windows.net; Database = PloomesAPI;User Id=testeapi;Password=Teste@api2020;"))
            {
                resultado = connection.Query<T>(sql,parameter).ToList();
            }
            return resultado;
        }
        public static void Command<T>(T objeto, bool editar = false) where T : BaseModel
        {
            using (var connection = new SqlConnection("Server = testeapi.database.windows.net; Database = PloomesAPI;User Id=testeapi;Password=Teste@api2020;"))
            {
                if (editar)
                    connection.Update(objeto);
                else
                    connection.Insert(objeto);
            }
        }
        public static void Delete<T>(int ID) where T : BaseModel
        {
            using (var connection = new SqlConnection("Server = testeapi.database.windows.net; Database = PloomesAPI;User Id=testeapi;Password=Teste@api2020;"))
            {
                string query = $"select * from {typeof(T).Name} where id = @id";
                var objeto = connection.Query<T>(query, new { ID });
                connection.Delete(objeto);
            }
        }
    }
}
