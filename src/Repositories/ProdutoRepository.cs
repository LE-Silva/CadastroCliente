using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente.Repositories
{
    public class ProdutoRepository
    {

        private void Create(Produto entity, SqlConnection conexao)
        {
            using (var conn = conexao)
            {
                conn.Open();

                var query = "INSERT INTO ProdutoProj (CdProduto, Descricao, Preco, IsActive, DtValidade) VALUES (@CdProduto, @Nome, @Preco, 'S', @DtValidade)";
                var command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@CdProduto", entity.CdProduto);
                command.Parameters.AddWithValue("@Descricao", entity.Descricao);
                command.Parameters.AddWithValue("@Preco", entity.Valor);
                command.Parameters.AddWithValue("@DtValidade", entity.DtValidade);

                var result = command.ExecuteNonQuery();
            }

        }
        private void Update(Produto entity, SqlConnection conexao)
        {
            using (var conn = conexao)
            {
                conn.Open();

                var query = "UPDATE ProdutoProj SET Descricao = @Descricao, Preco = @Preco, IsActive = @IsActive, DtValidade = @DtValidade WHERE CdProduto = @CdProduto";
                var command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@CdProduto", entity.CdProduto);
                command.Parameters.AddWithValue("@Descricao", entity.Descricao);
                command.Parameters.AddWithValue("@Preco", entity.Valor);
                command.Parameters.AddWithValue("@IsActive", entity.IsActive);
                command.Parameters.AddWithValue("@DtValidade", entity.DtValidade);

                var result = command.ExecuteNonQuery();
            }

        }

        private void Delete(Produto entity, SqlConnection conexao)
        {
            using (var conn = conexao)
            {
                conn.Open();

                var query = "DELETE FROM ProdutoProj WHERE CdProduto = @CdProduto";
                var command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@CdProduto", entity.CdProduto);

                var result = command.ExecuteNonQuery();
            }

        }

        private DataTable GetAll(SqlConnection conexao)
        {
            DataTable produtos = new DataTable();

            using (var conn = conexao)
            {
                conn.Open();

                var query = "SELECT CdProduto, Descricao, Preco, IsActive, DtValidade FROM ProdutoProj";
                var command = new SqlCommand(query, conn);

                using (var adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(produtos);
                }
                return produtos;
            }

        }

        private DataTable GetProdutoPorID(string cdProduto, SqlConnection conexao)
        {
            DataTable produto = new DataTable();

            using (var conn = conexao)
            {
                conn.Open();

                var query = "SELECT CdProduto, Descricao, Preco, IsActive, DtValidade FROM ProdutoProj WHERE CdProduto = @CdProduto";
                var command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@CdProduto", cdProduto);

                using (var adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(produto);
                }
            }

            return produto;
        }

        public ProdutoRepository()
        {

        }

    }
}
