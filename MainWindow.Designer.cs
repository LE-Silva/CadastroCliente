namespace CadastroCliente
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.msMenuSuperior = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenuSuperior
            // 
            resources.ApplyResources(this.msMenuSuperior, "msMenuSuperior");
            this.msMenuSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.msMenuSuperior.Name = "msMenuSuperior";
            // 
            // arquivoToolStripMenuItem
            // 
            resources.ApplyResources(this.arquivoToolStripMenuItem, "arquivoToolStripMenuItem");
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarClientesToolStripMenuItem,
            this.cadastrarProdutosToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            // 
            // cadastrarClientesToolStripMenuItem
            // 
            resources.ApplyResources(this.cadastrarClientesToolStripMenuItem, "cadastrarClientesToolStripMenuItem");
            this.cadastrarClientesToolStripMenuItem.Name = "cadastrarClientesToolStripMenuItem";
            // 
            // cadastrarProdutosToolStripMenuItem
            // 
            resources.ApplyResources(this.cadastrarProdutosToolStripMenuItem, "cadastrarProdutosToolStripMenuItem");
            this.cadastrarProdutosToolStripMenuItem.Name = "cadastrarProdutosToolStripMenuItem";
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.msMenuSuperior);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMenuSuperior;
            this.Name = "MainWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msMenuSuperior.ResumeLayout(false);
            this.msMenuSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenuSuperior;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarProdutosToolStripMenuItem;
    }
}