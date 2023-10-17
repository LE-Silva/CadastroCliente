namespace CadastroCliente
{
    partial class ProdutoWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcProduto = new System.Windows.Forms.TabControl();
            this.tpCadastrar = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpCadastrar = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gbDadosProduto = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDtValidade = new System.Windows.Forms.DateTimePicker();
            this.tpListar = new System.Windows.Forms.TabPage();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.tcProduto.SuspendLayout();
            this.tpCadastrar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpCadastrar.SuspendLayout();
            this.gbDadosProduto.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tpListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // tcProduto
            // 
            this.tcProduto.Controls.Add(this.tpCadastrar);
            this.tcProduto.Controls.Add(this.tpListar);
            this.tcProduto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcProduto.Location = new System.Drawing.Point(12, 12);
            this.tcProduto.Name = "tcProduto";
            this.tcProduto.SelectedIndex = 0;
            this.tcProduto.Size = new System.Drawing.Size(844, 571);
            this.tcProduto.TabIndex = 0;
            // 
            // tpCadastrar
            // 
            this.tpCadastrar.Controls.Add(this.tableLayoutPanel1);
            this.tpCadastrar.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.tpCadastrar.Location = new System.Drawing.Point(4, 29);
            this.tpCadastrar.Name = "tpCadastrar";
            this.tpCadastrar.Padding = new System.Windows.Forms.Padding(3);
            this.tpCadastrar.Size = new System.Drawing.Size(836, 538);
            this.tpCadastrar.TabIndex = 0;
            this.tpCadastrar.Text = "Cadastrar";
            this.tpCadastrar.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tlpCadastrar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbDadosProduto, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(824, 526);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tlpCadastrar
            // 
            this.tlpCadastrar.ColumnCount = 3;
            this.tlpCadastrar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCadastrar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCadastrar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCadastrar.Controls.Add(this.btnAdicionar, 0, 0);
            this.tlpCadastrar.Controls.Add(this.btnCancelar, 2, 0);
            this.tlpCadastrar.Controls.Add(this.btnSalvar, 1, 0);
            this.tlpCadastrar.Location = new System.Drawing.Point(3, 3);
            this.tlpCadastrar.Name = "tlpCadastrar";
            this.tlpCadastrar.RowCount = 2;
            this.tlpCadastrar.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCadastrar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCadastrar.Size = new System.Drawing.Size(818, 36);
            this.tlpCadastrar.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(3, 3);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(104, 28);
            this.btnAdicionar.TabIndex = 22;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
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
            this.btnSalvar.TabIndex = 24;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // gbDadosProduto
            // 
            this.gbDadosProduto.Controls.Add(this.tableLayoutPanel2);
            this.gbDadosProduto.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.gbDadosProduto.Location = new System.Drawing.Point(3, 45);
            this.gbDadosProduto.Name = "gbDadosProduto";
            this.gbDadosProduto.Size = new System.Drawing.Size(818, 481);
            this.gbDadosProduto.TabIndex = 2;
            this.gbDadosProduto.TabStop = false;
            this.gbDadosProduto.Text = "Dados";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel2.Controls.Add(this.lblCodigo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblDesc, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblValor, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtDescricao, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.chkAtivo, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtCodigo, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtValor, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 2, 2);
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
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.lblCodigo.Location = new System.Drawing.Point(3, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(49, 20);
            this.lblCodigo.TabIndex = 20;
            this.lblCodigo.Text = "Código";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.lblDesc.Location = new System.Drawing.Point(113, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(66, 20);
            this.lblDesc.TabIndex = 21;
            this.lblDesc.Text = "Descrição";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.lblValor.Location = new System.Drawing.Point(690, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(37, 20);
            this.lblValor.TabIndex = 22;
            this.lblValor.Text = "Valor";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(113, 23);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(571, 26);
            this.txtDescricao.TabIndex = 13;
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Enabled = false;
            this.chkAtivo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAtivo.Location = new System.Drawing.Point(3, 55);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(53, 24);
            this.chkAtivo.TabIndex = 18;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(3, 23);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(104, 26);
            this.txtCodigo.TabIndex = 11;
            // 
            // txtValor
            // 
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.Enabled = false;
            this.txtValor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(690, 23);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(104, 26);
            this.txtValor.TabIndex = 14;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.dtpDtValidade, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(690, 55);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(113, 109);
            this.tableLayoutPanel3.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Data de Validade";
            // 
            // dtpDtValidade
            // 
            this.dtpDtValidade.Enabled = false;
            this.dtpDtValidade.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.dtpDtValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtValidade.Location = new System.Drawing.Point(3, 24);
            this.dtpDtValidade.Name = "dtpDtValidade";
            this.dtpDtValidade.Size = new System.Drawing.Size(104, 26);
            this.dtpDtValidade.TabIndex = 19;
            this.dtpDtValidade.Value = new System.DateTime(2023, 10, 14, 22, 8, 39, 0);
            // 
            // tpListar
            // 
            this.tpListar.Controls.Add(this.dgvProdutos);
            this.tpListar.Location = new System.Drawing.Point(4, 29);
            this.tpListar.Name = "tpListar";
            this.tpListar.Padding = new System.Windows.Forms.Padding(3);
            this.tpListar.Size = new System.Drawing.Size(836, 538);
            this.tpListar.TabIndex = 1;
            this.tpListar.Text = "Listar Produtos";
            this.tpListar.UseVisualStyleBackColor = true;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(6, 6);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(824, 526);
            this.dgvProdutos.TabIndex = 0;
            // 
            // ProdutoWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 595);
            this.Controls.Add(this.tcProduto);
            this.Name = "ProdutoWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.tcProduto.ResumeLayout(false);
            this.tpCadastrar.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tlpCadastrar.ResumeLayout(false);
            this.gbDadosProduto.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tpListar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcProduto;
        private System.Windows.Forms.TabPage tpCadastrar;
        private System.Windows.Forms.TabPage tpListar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tlpCadastrar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox gbDadosProduto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.DateTimePicker dtpDtValidade;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dgvProdutos;
    }
}