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

        public void Create(Produto entity, string connectionString)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var query = "INSERT INTO ProdutoAtv3110 (CdProduto, Descricao, Preco, IsActive, DtValidade) VALUES (@CdProduto, @Descricao, @Preco, 'S', @DtValidade)";
                var command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@CdProduto", entity.CdProduto);
                command.Parameters.AddWithValue("@Descricao", entity.Descricao);
                command.Parameters.AddWithValue("@Preco", entity.Valor);
                command.Parameters.AddWithValue("@DtValidade", entity.DtValidade);

                var result = command.ExecuteNonQuery();
            }

        }
        public void Update(Produto entity, string connectionString)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var query = "UPDATE ProdutoAtv3110 SET Descricao = @Descricao, Preco = @Preco, IsActive = @IsActive, DtValidade = @DtValidade WHERE CdProduto = @CdProduto";
                var command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@CdProduto", entity.CdProduto);
                command.Parameters.AddWithValue("@Descricao", entity.Descricao);
                command.Parameters.AddWithValue("@Preco", entity.Valor);
                command.Parameters.AddWithValue("@IsActive", entity.getIsActiveChar());
                command.Parameters.AddWithValue("@DtValidade", entity.DtValidade);

                var result = command.ExecuteNonQuery();
            }

        }

        public void Delete(string cdproduto, string connectionString)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var query = "DELETE FROM ProdutoAtv3110 WHERE CdProduto = @CdProduto";
                var command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@CdProduto", cdproduto);

                var result = command.ExecuteNonQuery();
            }

        }

        public DataTable GetAll(string connectionString)
        {
            DataTable produtos = new DataTable();

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var query = "SELECT CdProduto, Descricao, Preco, IsActive, DtValidade FROM ProdutoAtv3110";
                var command = new SqlCommand(query, conn);

                using (var adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(produtos);
                }
                return produtos;
            }

        }

        public DataTable GetProdutoPorID(string cdProduto, string connectionString)
        {
            DataTable produto = new DataTable();

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var query = "SELECT CdProduto, Descricao, Preco, IsActive, DtValidade FROM ProdutoAtv3110 WHERE CdProduto = @CdProduto";
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
