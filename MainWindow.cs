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
            //Label, Textbox, Combobox, RadioButton, Checkbox, Button
            //Codigo, Descricao, Status, CPF, TP pessoa, Cliente Premium

            var tiposPessoa = new string[] {"Masculino", "Feminino", "Juridico"};

            cbTpPessoa.DataSource = tiposPessoa;
            cbTpPessoa.SelectedIndex = -1;
            cbTpPessoa.SelectedIndexChanged += cbTpPessoq_SelectedIndexChanged;

            btnAdicionar.Click += btnAdicionar_Click;
            btnCancelar.Click += btnCancelar_Click;

            txtCodigo.LostFocus += txtCodigo_LostFocus;

            mtxtCPF.Mask = "999.999.999-99";

            void btnAdicionar_Click(object sender, EventArgs e)
            {
                alterarStatusCampos();
            }
            void btnCancelar_Click(Object sender, EventArgs e)
            {
                alterarStatusCampos();

            }
            void txtCodigo_LostFocus(object sender, EventArgs e)
            {
                if (string.IsNullOrEmpty(txtCodigo.Text.Trim()))
                {
                    MessageBox.Show("Código não pode estar em branco!");
                    txtCodigo.Focus();
                }
            }
            void cbTpPessoq_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (cbTpPessoa.Text == "Juridico")
                {
                    mtxtCPF.Mask = "99.999.999/9999-99";
                    labelCPF.Text = "CNPJ";
                    labelClienteDescricao.Text = "Razão Social";
                }
                else
                {
                    mtxtCPF.Mask = "999.999.999-99";
                    labelCPF.Text = "CPF";
                    labelClienteDescricao.Text = "Nome";
                } 
                    
            }



            void alterarStatusCampos()
            {
                btnAdicionar.Enabled = !btnAdicionar.Enabled;
                txtCodigo.Enabled = !txtCodigo.Enabled;
                mtxtCPF.Enabled = !mtxtCPF.Enabled;
                txtNome.Enabled = !txtNome.Enabled;
                btnCancelar.Enabled = !btnCancelar.Enabled;
                cbTpPessoa.Enabled = !cbTpPessoa.Enabled;
                rbtnAtivo.Enabled = !rbtnAtivo.Enabled;
                rbtnInativo.Enabled = !rbtnInativo.Enabled;
                rbtnAtivo.Checked = !rbtnAtivo.Checked;
                chkCliPremium.Enabled = !chkCliPremium.Enabled;
            }
        }
    }
}
