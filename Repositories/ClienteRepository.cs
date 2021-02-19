using PloomesAPI.Model;
using System.Collections.Generic;


namespace PloomesAPI.Repositories
{
    public static class ClienteRepository
    {
        public static List<Cliente> Buscar(int ID, string Nome = null)
        {
            string sql = "select * from Cliente";

            if(ID>0)
            {
                sql += " where ID = @IDCliente";
            }
            var retorno = BaseRepository.QuerySql<Cliente>(sql,new { IDCliente = ID});

            return retorno;
        }

        public static void Gravar(Cliente cliente)
        {
            BaseRepository.Command(cliente);
        }

        public static void Atualizar(Cliente cliente)
        {
            BaseRepository.Command(cliente, true);
        }

        public static void Delete(int ID)
        {
            BaseRepository.Delete<Cliente>(ID);
        }
    }
}
