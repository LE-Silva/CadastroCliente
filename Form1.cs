using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroCliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var datasetTeste = new DataSet();

            var dataTable = new DataTable();
            dataTable.TableName = "Test";

            var colunaSelecao = new DataColumn();
            colunaSelecao.ColumnName = nameof(Cliente.StAtivo);
            colunaSelecao.DataType = typeof(bool);
            dataTable.Columns.Add(colunaSelecao);

            var coluna = new DataColumn();
            coluna.ColumnName = nameof(Cliente.CdCliente);
            coluna.DataType = typeof(string);
            dataTable.Columns.Add(coluna);

            var colunaNome = new DataColumn();
            colunaNome.ColumnName = nameof(Cliente.Nome);
            colunaNome.DataType = typeof(string);
            dataTable.Columns.Add(colunaNome);

            var linha = dataTable.NewRow();
            linha[nameof(Cliente.CdCliente)] = "1";
            linha[nameof(Cliente.Nome)] = "TESTE";
            dataTable.Rows.Add(linha);

            linha = dataTable.NewRow();
            linha[nameof(Cliente.CdCliente)] = "2";
            linha[nameof(Cliente.Nome)] = "TESTE 2";
            dataTable.Rows.Add(linha);

            dataTable.AcceptChanges();

            datasetTeste.Tables.Add(dataTable);

            dataGridView1.DataSource = datasetTeste.Tables["Test"];

            dataGridView1.Columns[nameof(Cliente.CdCliente)].HeaderText = "Código";

            comboBox1.DisplayMember = nameof(Cliente.Nome);
            comboBox1.ValueMember = nameof(Cliente.CdCliente);
            comboBox1.DataSource = datasetTeste.Tables["Test"];

            listView1 = new ListView();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.Columns.Clear();
            listView1.Columns.Add(nameof(Cliente.CdCliente), 100);
            listView1.Columns.Add(nameof(Cliente.Nome), 100);

            foreach (DataRow item in dataTable.Rows)
            {
                var linha2 = new ListViewItem();

                linha2.Text = "teste";
                linha2.SubItems.Add(item[nameof(Cliente.CdCliente)]?.ToString());
                linha2.SubItems.Add(item[nameof(Cliente.Nome)]?.ToString());

                listView1.Items.Add(linha2);
            }

            listView1.Refresh();

            //sqlconnection

            var conexao = new SqlConnection("");
            var comando = new SqlCommand("SELECT * FROM cliente", conexao);
            var linhas = comando.ExecuteReader();
        }
    }
}
