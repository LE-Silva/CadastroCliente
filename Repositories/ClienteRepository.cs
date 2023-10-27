using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente.Repositories
{
    public class ClienteRepository
    {

        private void Create(Cliente entity, SqlConnection conexao)
        {
            using (var conn = conexao)
            {
                conn.Open();

                var query = "INSERT INTO ClienteAtv2510 (CdCliente, Nome) VALUES (@CdCliente, @Nome)";
                var command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@CdCliente", entity.CdCliente);
                command.Parameters.AddWithValue("@Nome", entity.Nome);

                var result = command.ExecuteNonQuery();
            }

        }
    }
}
