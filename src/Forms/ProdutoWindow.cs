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
    public partial class ProdutoWindow : Form
    {

        BindingList<Produto> _listaProdutos = new BindingList<Produto> { };
        public ProdutoWindow()
        {
            InitializeComponent();

            btnAdicionar.Click += btnAdicionar_Click;
            btnCancelar.Click += btnCancelar_Click;
            btnSalvar.Click += btnSalvar_Click;

            txtCodigo.EnabledChanged += txtCodigo_EnabledChanged;
            txtDescricao.EnabledChanged += txtDescricao_EnabledChanged;
            txtValor.EnabledChanged += txtValor_EnabledChanged;
            chkAtivo.EnabledChanged += chkAtivo_EnabledChanged;
            dtpDtValidade.EnabledChanged += dtpDtValidade_EnabledChanged;

            dgvProdutos.DoubleClick += dgvProdutos_DoubleClick;

            dgvProdutos.DataSource = _listaProdutos;
        }

        #region cliques
        void btnAdicionar_Click(object sender, EventArgs e)
        {
            alterarStatusCampos();
            txtCodigo.Focus();
        }
        void btnCancelar_Click(object sender, EventArgs e)
        {
            alterarStatusCampos();
        }
        void btnSalvar_Click(object sender, EventArgs e)
        {
            if(Decimal.TryParse(txtValor.Text, out decimal parcedValue))
            {
                _listaProdutos.Add(new Produto(txtCodigo.Text, txtDescricao.Text, true, dtpDtValidade.Value, parcedValue));
                alterarStatusCampos();
                MessageBox.Show("Cadastrado com Sucesso!");
            }
            else
            {
                MessageBox.Show("Valor do produto inválido");
            }
        }
        void txtCodigo_EnabledChanged(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
        }
        void txtDescricao_EnabledChanged(object sender, EventArgs e)
        {
            txtDescricao.Text = "";
        }
        void txtValor_EnabledChanged(object sender, EventArgs e)
        {
            txtValor.Text = "";
        }
        void chkAtivo_EnabledChanged(object sender, EventArgs e)
        {
            chkAtivo.Checked = false;
        }
        void dtpDtValidade_EnabledChanged(object sender, EventArgs e)
        {
            dtpDtValidade.Value = DateTime.Now;
        }
        void dgvProdutos_DoubleClick(object sender, EventArgs e)
        {
            var produto = (Produto)dgvProdutos.SelectedRows[0].DataBoundItem;
            txtCodigo.Text = produto.CdProduto.ToString();
            txtDescricao.Text = produto.Descricao.ToString();
            txtValor.Text = produto.Valor.ToString();
            chkAtivo.Checked = produto.IsActive;
            dtpDtValidade.Value = produto.DtValidade;
        }
        #endregion
        void alterarStatusCampos()
        {
            //limparCampos();
            btnAdicionar.Enabled = !btnAdicionar.Enabled;
            btnSalvar.Enabled = !btnSalvar.Enabled;
            txtCodigo.Enabled = !txtCodigo.Enabled;
            txtDescricao.Enabled = !txtDescricao.Enabled;
            btnCancelar.Enabled = !btnCancelar.Enabled;
            chkAtivo.Enabled = !chkAtivo.Enabled;
            txtValor.Enabled = !txtValor.Enabled;
            dtpDtValidade.Enabled = !dtpDtValidade.Enabled;
        }
    }
}
