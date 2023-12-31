﻿using CadastroCliente.Repositories;
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
    public partial class ProdutoWindow : Form
    {
        DataTable _dataTableProduto = new DataTable();
        ProdutoRepository _repositorio = new ProdutoRepository();
        string connectionString = "Server=172.16.3.50;Database=SPT_LEJ_DbNutAG;User Id=sa;Password=dp;";
        public ProdutoWindow()
        {
            InitializeComponent();

            btnAdicionar.Click += btnAdicionar_Click;
            btnCancelar.Click += btnCancelar_Click;
            btnSalvar.Click += btnSalvar_Click;
            btnExcluir.Click += btnExcluir_Click;

            txtCodigo.EnabledChanged += txtCodigo_EnabledChanged;
            txtDescricao.EnabledChanged += txtDescricao_EnabledChanged;
            txtValor.EnabledChanged += txtValor_EnabledChanged;
            chkAtivo.EnabledChanged += chkAtivo_EnabledChanged;
            dtpDtValidade.EnabledChanged += dtpDtValidade_EnabledChanged;

            dgvProdutos.DoubleClick += dgvProdutos_DoubleClick;

            carregarGridProdutos();
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
            var produto = _repositorio.GetProdutoPorID(txtCodigo.Text, connectionString);
            if (produto.Rows.Count > 0)
                atualizaProduto();
            else
                insereProduto();

            carregarGridProdutos();
        }
        void btnExcluir_Click(object sender, EventArgs e)
        {
            _repositorio.Delete(txtCodigo.Text, connectionString);
            carregarGridProdutos();
            MessageBox.Show("Excluido com sucesso!");
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
            if (dgvProdutos.SelectedRows.Count == 1)
            {
                alterarStatusCampos();
                DataGridViewRow selectedRow = dgvProdutos.SelectedRows[0];
                txtCodigo.Text = selectedRow.Cells["CdProduto"].Value.ToString();
                txtDescricao.Text = selectedRow.Cells["Descricao"].Value.ToString();
                txtValor.Text = selectedRow.Cells["Preco"].Value.ToString();
                chkAtivo.Checked = getIsActiveBool(selectedRow.Cells["IsActive"].Value.ToString());
                dtpDtValidade.Value = Convert.ToDateTime(selectedRow.Cells["DtValidade"].Value);
                tcProduto.SelectedIndex = 0;
            }
        }
        #endregion
        void alterarStatusCampos()
        {
            //limparCampos();
            btnAdicionar.Enabled = !btnAdicionar.Enabled;
            btnSalvar.Enabled = !btnSalvar.Enabled;
            btnExcluir.Enabled = !btnExcluir.Enabled;
            txtCodigo.Enabled = !txtCodigo.Enabled;
            txtDescricao.Enabled = !txtDescricao.Enabled;
            btnCancelar.Enabled = !btnCancelar.Enabled;
            chkAtivo.Enabled = !chkAtivo.Enabled;
            txtValor.Enabled = !txtValor.Enabled;
            dtpDtValidade.Enabled = !dtpDtValidade.Enabled;
        }
        bool getIsActiveBool(string isActiveChar)
        {
            if (isActiveChar == "N")
                return false;
            return true;
        }

        void atualizaProduto()
        {
            if (Decimal.TryParse(txtValor.Text, out decimal parcedValue))
            {
                _repositorio.Update(new Produto(txtCodigo.Text, txtDescricao.Text, chkAtivo.Checked, dtpDtValidade.Value, parcedValue), connectionString);
                MessageBox.Show("Atualizado com Sucesso!");
                _dataTableProduto = _repositorio.GetAll(connectionString);
                dgvProdutos.Refresh();
            }
            else
            {
                MessageBox.Show("Valor do produto inválido");
            }
        }
        void insereProduto()
        {
            if (Decimal.TryParse(txtValor.Text, out decimal parcedValue))
            {
                _repositorio.Create(new Produto(txtCodigo.Text, txtDescricao.Text, true, dtpDtValidade.Value, parcedValue), connectionString);
                MessageBox.Show("Cadastrado com Sucesso!");
                _dataTableProduto = _repositorio.GetAll(connectionString);
                dgvProdutos.Refresh();
            }
            else
            {
                MessageBox.Show("Valor do produto inválido");
            }
        }
        void carregarGridProdutos()
        {
            _dataTableProduto = _repositorio.GetAll(connectionString);
            dgvProdutos.DataSource = _dataTableProduto;
            dgvProdutos.Refresh();
        }
    }
}
