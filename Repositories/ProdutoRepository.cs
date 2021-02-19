using PloomesAPI.Model;
using System.Collections.Generic;


namespace PloomesAPI.Repositories
{
    public static class ProdutoRepository
    {
        public static List<Produto> Buscar(int ID, string Nome = null)
        {
            string sql = "select * from Produto";

            if(ID>0)
            {
                sql += " where ID = @IDProduto";
            }
            var retorno = BaseRepository.QuerySql<Produto>(sql,new { IDProduto = ID});

            return retorno;
        }

        public static void Gravar(Produto produto)
        {
            BaseRepository.Command(produto);
        }

        public static void Atualizar(Produto produto)
        {
            BaseRepository.Command(produto, true);
        }

        public static void Delete(int ID)
        {
            BaseRepository.Delete<Produto>(ID);
        }
    }
}
