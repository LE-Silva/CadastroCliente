using System.Globalization;

namespace CadastroCliente
{
    partial class MainWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbClienteDados = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTpPessoa = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.rbtnInativo = new System.Windows.Forms.RadioButton();
            this.rbtnAtivo = new System.Windows.Forms.RadioButton();
            this.labelCPF = new System.Windows.Forms.Label();
            this.chkCliPremium = new System.Windows.Forms.CheckBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.labelClienteDescricao = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.labelCdCliente = new System.Windows.Forms.Label();
            this.gbListaClientes = new System.Windows.Forms.GroupBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.gbClienteDados.SuspendLayout();
            this.gbListaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gbClienteDados
            // 
            this.gbClienteDados.Controls.Add(this.btnSalvar);
            this.gbClienteDados.Controls.Add(this.mtxtCPF);
            this.gbClienteDados.Controls.Add(this.label1);
            this.gbClienteDados.Controls.Add(this.cbTpPessoa);
            this.gbClienteDados.Controls.Add(this.btnCancelar);
            this.gbClienteDados.Controls.Add(this.btnAdicionar);
            this.gbClienteDados.Controls.Add(this.rbtnInativo);
            this.gbClienteDados.Controls.Add(this.rbtnAtivo);
            this.gbClienteDados.Controls.Add(this.labelCPF);
            this.gbClienteDados.Controls.Add(this.chkCliPremium);
            this.gbClienteDados.Controls.Add(this.txtNome);
            this.gbClienteDados.Controls.Add(this.labelClienteDescricao);
            this.gbClienteDados.Controls.Add(this.txtCodigo);
            this.gbClienteDados.Controls.Add(this.labelCdCliente);
            this.gbClienteDados.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbClienteDados.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbClienteDados.Location = new System.Drawing.Point(12, 12);
            this.gbClienteDados.Name = "gbClienteDados";
            this.gbClienteDados.Size = new System.Drawing.Size(844, 185);
            this.gbClienteDados.TabIndex = 9;
            this.gbClienteDados.TabStop = false;
            this.gbClienteDados.Text = "Dados do Cliente";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(605, 136);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(104, 28);
            this.btnSalvar.TabIndex = 21;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // mtxtCPF
            // 
            this.mtxtCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtCPF.Culture = new System.Globalization.CultureInfo("");
            this.mtxtCPF.Enabled = false;
            this.mtxtCPF.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.mtxtCPF.Location = new System.Drawing.Point(526, 53);
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.Size = new System.Drawing.Size(155, 26);
            this.mtxtCPF.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.label1.Location = new System.Drawing.Point(683, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tipo de Pessoa";
            // 
            // cbTpPessoa
            // 
            this.cbTpPessoa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTpPessoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTpPessoa.Enabled = false;
            this.cbTpPessoa.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbTpPessoa.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.cbTpPessoa.FormattingEnabled = true;
            this.cbTpPessoa.Location = new System.Drawing.Point(687, 52);
            this.cbTpPessoa.Name = "cbTpPessoa";
            this.cbTpPessoa.Size = new System.Drawing.Size(132, 27);
            this.cbTpPessoa.TabIndex = 16;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(715, 136);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 28);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(495, 136);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(104, 28);
            this.btnAdicionar.TabIndex = 20;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // rbtnInativo
            // 
            this.rbtnInativo.AutoSize = true;
            this.rbtnInativo.Enabled = false;
            this.rbtnInativo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnInativo.Location = new System.Drawing.Point(757, 85);
            this.rbtnInativo.Name = "rbtnInativo";
            this.rbtnInativo.Size = new System.Drawing.Size(62, 24);
            this.rbtnInativo.TabIndex = 19;
            this.rbtnInativo.Text = "Inativo";
            this.rbtnInativo.UseVisualStyleBackColor = true;
            // 
            // rbtnAtivo
            // 
            this.rbtnAtivo.AutoSize = true;
            this.rbtnAtivo.Enabled = false;
            this.rbtnAtivo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAtivo.Location = new System.Drawing.Point(699, 86);
            this.rbtnAtivo.Name = "rbtnAtivo";
            this.rbtnAtivo.Size = new System.Drawing.Size(52, 24);
            this.rbtnAtivo.TabIndex = 18;
            this.rbtnAtivo.Text = "Ativo";
            this.rbtnAtivo.UseVisualStyleBackColor = true;
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.labelCPF.Location = new System.Drawing.Point(522, 30);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(34, 20);
            this.labelCPF.TabIndex = 13;
            this.labelCPF.Text = "CPF";
            // 
            // chkCliPremium
            // 
            this.chkCliPremium.AutoSize = true;
            this.chkCliPremium.Enabled = false;
            this.chkCliPremium.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCliPremium.Location = new System.Drawing.Point(27, 85);
            this.chkCliPremium.Name = "chkCliPremium";
            this.chkCliPremium.Size = new System.Drawing.Size(121, 24);
            this.chkCliPremium.TabIndex = 17;
            this.chkCliPremium.Text = "Cliente Premium";
            this.chkCliPremium.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(137, 53);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(383, 26);
            this.txtNome.TabIndex = 12;
            // 
            // labelClienteDescricao
            // 
            this.labelClienteDescricao.AutoSize = true;
            this.labelClienteDescricao.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.labelClienteDescricao.Location = new System.Drawing.Point(133, 30);
            this.labelClienteDescricao.Name = "labelClienteDescricao";
            this.labelClienteDescricao.Size = new System.Drawing.Size(43, 20);
            this.labelClienteDescricao.TabIndex = 11;
            this.labelClienteDescricao.Text = "Nome";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(27, 53);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(104, 26);
            this.txtCodigo.TabIndex = 10;
            // 
            // labelCdCliente
            // 
            this.labelCdCliente.AutoSize = true;
            this.labelCdCliente.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.labelCdCliente.Location = new System.Drawing.Point(23, 29);
            this.labelCdCliente.Name = "labelCdCliente";
            this.labelCdCliente.Size = new System.Drawing.Size(49, 20);
            this.labelCdCliente.TabIndex = 9;
            this.labelCdCliente.Text = "Código";
            // 
            // gbListaClientes
            // 
            this.gbListaClientes.Controls.Add(this.dgvClientes);
            this.gbListaClientes.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.gbListaClientes.Location = new System.Drawing.Point(13, 201);
            this.gbListaClientes.Name = "gbListaClientes";
            this.gbListaClientes.Size = new System.Drawing.Size(843, 364);
            this.gbListaClientes.TabIndex = 10;
            this.gbListaClientes.TabStop = false;
            this.gbListaClientes.Text = "Lista de Clientes";
            // 
            // dgvClientes
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(7, 21);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(830, 336);
            this.dgvClientes.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 595);
            this.Controls.Add(this.gbListaClientes);
            this.Controls.Add(this.gbClienteDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.Text = "Cadastro de Clientes";
            this.gbClienteDados.ResumeLayout(false);
            this.gbClienteDados.PerformLayout();
            this.gbListaClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbClienteDados;
        private System.Windows.Forms.CheckBox chkCliPremium;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label labelClienteDescricao;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label labelCdCliente;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.RadioButton rbtnInativo;
        private System.Windows.Forms.RadioButton rbtnAtivo;
        private System.Windows.Forms.ComboBox cbTpPessoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxtCPF;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox gbListaClientes;
        private System.Windows.Forms.DataGridView dgvClientes;
    }
}

