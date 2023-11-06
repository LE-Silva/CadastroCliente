using System.Globalization;

namespace CadastroCliente
{
    partial class ClienteWindow
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteWindow));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ttCodigo = new System.Windows.Forms.ToolTip(this.components);
            this.ttNome = new System.Windows.Forms.ToolTip(this.components);
            this.ttCPF = new System.Windows.Forms.ToolTip(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tsListaCliente = new System.Windows.Forms.ToolStrip();
            this.tsddbListaC = new System.Windows.Forms.ToolStripDropDownButton();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desmarcarTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selecionarTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbDadosProduto = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCPF = new System.Windows.Forms.Label();
            this.labelClienteDescricao = new System.Windows.Forms.Label();
            this.labelCdCliente = new System.Windows.Forms.Label();
            this.rbtnAtivo = new System.Windows.Forms.RadioButton();
            this.chkCliPremium = new System.Windows.Forms.CheckBox();
            this.cbTpPessoa = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.rbtnInativo = new System.Windows.Forms.RadioButton();
            this.tlpCadastrar = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.tcCadastrarP = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.tsListaCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbDadosProduto.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tlpCadastrar.SuspendLayout();
            this.tcCadastrarP.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tsListaCliente);
            this.tabPage2.Controls.Add(this.dgvClientes);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(836, 520);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Listar Clientes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tsListaCliente
            // 
            this.tsListaCliente.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsListaCliente.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddbListaC});
            this.tsListaCliente.Location = new System.Drawing.Point(3, 492);
            this.tsListaCliente.Name = "tsListaCliente";
            this.tsListaCliente.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tsListaCliente.Size = new System.Drawing.Size(830, 25);
            this.tsListaCliente.TabIndex = 4;
            this.tsListaCliente.Text = "toolStrip1";
            // 
            // tsddbListaC
            // 
            this.tsddbListaC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddbListaC.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excluirToolStripMenuItem,
            this.desmarcarTodosToolStripMenuItem,
            this.selecionarTodosToolStripMenuItem});
            this.tsddbListaC.Image = ((System.Drawing.Image)(resources.GetObject("tsddbListaC.Image")));
            this.tsddbListaC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbListaC.Name = "tsddbListaC";
            this.tsddbListaC.Size = new System.Drawing.Size(64, 22);
            this.tsddbListaC.Text = "Funções";
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            // 
            // desmarcarTodosToolStripMenuItem
            // 
            this.desmarcarTodosToolStripMenuItem.Name = "desmarcarTodosToolStripMenuItem";
            this.desmarcarTodosToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.desmarcarTodosToolStripMenuItem.Text = "Desmarcar Todos";
            // 
            // selecionarTodosToolStripMenuItem
            // 
            this.selecionarTodosToolStripMenuItem.Name = "selecionarTodosToolStripMenuItem";
            this.selecionarTodosToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.selecionarTodosToolStripMenuItem.Text = "Selecionar Todos";
            // 
            // dgvClientes
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(0, 0);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(836, 524);
            this.dgvClientes.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(836, 520);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastrar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gbDadosProduto, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tlpCadastrar, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(824, 511);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // gbDadosProduto
            // 
            this.gbDadosProduto.Controls.Add(this.tableLayoutPanel2);
            this.gbDadosProduto.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.gbDadosProduto.Location = new System.Drawing.Point(3, 45);
            this.gbDadosProduto.Name = "gbDadosProduto";
            this.gbDadosProduto.Size = new System.Drawing.Size(818, 463);
            this.gbDadosProduto.TabIndex = 3;
            this.gbDadosProduto.TabStop = false;
            this.gbDadosProduto.Text = "Dados";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel2.Controls.Add(this.txtCodigo, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelCPF, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelClienteDescricao, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelCdCliente, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.rbtnAtivo, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.chkCliPremium, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbTpPessoa, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtNome, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.mtxtCPF, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.rbtnInativo, 3, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 22);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(806, 453);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(3, 23);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(104, 26);
            this.txtCodigo.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.label1.Location = new System.Drawing.Point(681, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Tipo de Pessoa";
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.labelCPF.Location = new System.Drawing.Point(536, 0);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(34, 20);
            this.labelCPF.TabIndex = 33;
            this.labelCPF.Text = "CPF";
            // 
            // labelClienteDescricao
            // 
            this.labelClienteDescricao.AutoSize = true;
            this.labelClienteDescricao.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.labelClienteDescricao.Location = new System.Drawing.Point(130, 0);
            this.labelClienteDescricao.Name = "labelClienteDescricao";
            this.labelClienteDescricao.Size = new System.Drawing.Size(43, 20);
            this.labelClienteDescricao.TabIndex = 32;
            this.labelClienteDescricao.Text = "Nome";
            // 
            // labelCdCliente
            // 
            this.labelCdCliente.AutoSize = true;
            this.labelCdCliente.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.labelCdCliente.Location = new System.Drawing.Point(3, 0);
            this.labelCdCliente.Name = "labelCdCliente";
            this.labelCdCliente.Size = new System.Drawing.Size(49, 20);
            this.labelCdCliente.TabIndex = 31;
            this.labelCdCliente.Text = "Código";
            // 
            // rbtnAtivo
            // 
            this.rbtnAtivo.AutoSize = true;
            this.rbtnAtivo.Enabled = false;
            this.rbtnAtivo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAtivo.Location = new System.Drawing.Point(536, 55);
            this.rbtnAtivo.Name = "rbtnAtivo";
            this.rbtnAtivo.Size = new System.Drawing.Size(52, 24);
            this.rbtnAtivo.TabIndex = 29;
            this.rbtnAtivo.Text = "Ativo";
            this.rbtnAtivo.UseVisualStyleBackColor = true;
            // 
            // chkCliPremium
            // 
            this.chkCliPremium.AutoSize = true;
            this.chkCliPremium.Enabled = false;
            this.chkCliPremium.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCliPremium.Location = new System.Drawing.Point(3, 55);
            this.chkCliPremium.Name = "chkCliPremium";
            this.chkCliPremium.Size = new System.Drawing.Size(121, 24);
            this.chkCliPremium.TabIndex = 28;
            this.chkCliPremium.Text = "Cliente Premium";
            this.chkCliPremium.UseVisualStyleBackColor = true;
            // 
            // cbTpPessoa
            // 
            this.cbTpPessoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTpPessoa.Enabled = false;
            this.cbTpPessoa.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbTpPessoa.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.cbTpPessoa.FormattingEnabled = true;
            this.cbTpPessoa.Location = new System.Drawing.Point(681, 23);
            this.cbTpPessoa.Name = "cbTpPessoa";
            this.cbTpPessoa.Size = new System.Drawing.Size(122, 28);
            this.cbTpPessoa.TabIndex = 24;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(130, 23);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(400, 26);
            this.txtNome.TabIndex = 26;
            // 
            // mtxtCPF
            // 
            this.mtxtCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtCPF.Culture = new System.Globalization.CultureInfo("");
            this.mtxtCPF.Enabled = false;
            this.mtxtCPF.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.mtxtCPF.Location = new System.Drawing.Point(536, 23);
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.Size = new System.Drawing.Size(113, 26);
            this.mtxtCPF.TabIndex = 27;
            // 
            // rbtnInativo
            // 
            this.rbtnInativo.AutoSize = true;
            this.rbtnInativo.Enabled = false;
            this.rbtnInativo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnInativo.Location = new System.Drawing.Point(681, 55);
            this.rbtnInativo.Name = "rbtnInativo";
            this.rbtnInativo.Size = new System.Drawing.Size(62, 24);
            this.rbtnInativo.TabIndex = 30;
            this.rbtnInativo.Text = "Inativo";
            this.rbtnInativo.UseVisualStyleBackColor = true;
            // 
            // tlpCadastrar
            // 
            this.tlpCadastrar.ColumnCount = 4;
            this.tlpCadastrar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCadastrar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCadastrar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCadastrar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 488F));
            this.tlpCadastrar.Controls.Add(this.btnCancelar, 0, 0);
            this.tlpCadastrar.Controls.Add(this.btnSalvar, 0, 0);
            this.tlpCadastrar.Controls.Add(this.btnAdicionar, 0, 0);
            this.tlpCadastrar.Controls.Add(this.btnExcluir, 3, 0);
            this.tlpCadastrar.Location = new System.Drawing.Point(3, 3);
            this.tlpCadastrar.Name = "tlpCadastrar";
            this.tlpCadastrar.RowCount = 1;
            this.tlpCadastrar.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCadastrar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpCadastrar.Size = new System.Drawing.Size(818, 36);
            this.tlpCadastrar.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(223, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 28);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(113, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(104, 28);
            this.btnSalvar.TabIndex = 22;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(3, 3);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(104, 28);
            this.btnAdicionar.TabIndex = 21;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(333, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(104, 28);
            this.btnExcluir.TabIndex = 24;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // tcCadastrarP
            // 
            this.tcCadastrarP.Controls.Add(this.tabPage1);
            this.tcCadastrarP.Controls.Add(this.tabPage2);
            this.tcCadastrarP.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.tcCadastrarP.Location = new System.Drawing.Point(12, 12);
            this.tcCadastrarP.Name = "tcCadastrarP";
            this.tcCadastrarP.SelectedIndex = 0;
            this.tcCadastrarP.Size = new System.Drawing.Size(844, 553);
            this.tcCadastrarP.TabIndex = 11;
            // 
            // ClienteWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 595);
            this.Controls.Add(this.tcCadastrarP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ClienteWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tsListaCliente.ResumeLayout(false);
            this.tsListaCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbDadosProduto.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tlpCadastrar.ResumeLayout(false);
            this.tcCadastrarP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip ttCodigo;
        private System.Windows.Forms.ToolTip ttNome;
        private System.Windows.Forms.ToolTip ttCPF;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip tsListaCliente;
        private System.Windows.Forms.ToolStripDropDownButton tsddbListaC;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desmarcarTodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selecionarTodosToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbDadosProduto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.Label labelClienteDescricao;
        private System.Windows.Forms.Label labelCdCliente;
        private System.Windows.Forms.RadioButton rbtnAtivo;
        private System.Windows.Forms.CheckBox chkCliPremium;
        private System.Windows.Forms.ComboBox cbTpPessoa;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mtxtCPF;
        private System.Windows.Forms.RadioButton rbtnInativo;
        private System.Windows.Forms.TableLayoutPanel tlpCadastrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TabControl tcCadastrarP;
        private System.Windows.Forms.Button btnExcluir;
    }
}

