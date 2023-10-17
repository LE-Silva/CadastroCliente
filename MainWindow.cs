using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroCliente
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            cadastrarClientesToolStripMenuItem.Click += cadastrarClientesToolStripMenuItem_Click;
            cadastrarProdutosToolStripMenuItem.Click += cadastrarProdutosToolStripMenuItem_Click;
        }

        void cadastrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cadastroCliente = new ClienteWindow();
            cadastroCliente.MdiParent = this;
            cadastroCliente.Show();
        }

        void cadastrarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cadastroProduto = new ProdutoWindow();
            cadastroProduto.MdiParent = this;
            cadastroProduto.Show();
        }
    }
}
