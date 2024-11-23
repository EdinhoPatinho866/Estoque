namespace Dados
{
    partial class FrmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            gerirProdutosToolStripMenuItem = new ToolStripMenuItem();
            gerirProdutosToolStripMenuItem1 = new ToolStripMenuItem();
            verificarValidadeDeProdutosToolStripMenuItem = new ToolStripMenuItem();
            adcionarbaixarProdutoToolStripMenuItem = new ToolStripMenuItem();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            cadastrarCategoriaToolStripMenuItem = new ToolStripMenuItem();
            cadastrarFornecedoresToolStripMenuItem = new ToolStripMenuItem();
            cadastrarMarcasToolStripMenuItem = new ToolStripMenuItem();
            cadastrarProdutoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            cadastrarUsuariosToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            fecharToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { gerirProdutosToolStripMenuItem, cadastrosToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1375, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // gerirProdutosToolStripMenuItem
            // 
            gerirProdutosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gerirProdutosToolStripMenuItem1, verificarValidadeDeProdutosToolStripMenuItem, adcionarbaixarProdutoToolStripMenuItem });
            gerirProdutosToolStripMenuItem.Name = "gerirProdutosToolStripMenuItem";
            gerirProdutosToolStripMenuItem.Size = new Size(95, 20);
            gerirProdutosToolStripMenuItem.Text = "Gerir Produtos";
            // 
            // gerirProdutosToolStripMenuItem1
            // 
            gerirProdutosToolStripMenuItem1.Name = "gerirProdutosToolStripMenuItem1";
            gerirProdutosToolStripMenuItem1.Size = new Size(230, 22);
            gerirProdutosToolStripMenuItem1.Text = "Registro de produtos";
            // 
            // verificarValidadeDeProdutosToolStripMenuItem
            // 
            verificarValidadeDeProdutosToolStripMenuItem.Name = "verificarValidadeDeProdutosToolStripMenuItem";
            verificarValidadeDeProdutosToolStripMenuItem.Size = new Size(230, 22);
            verificarValidadeDeProdutosToolStripMenuItem.Text = "Verificar Validade de produtos";
            // 
            // adcionarbaixarProdutoToolStripMenuItem
            // 
            adcionarbaixarProdutoToolStripMenuItem.Name = "adcionarbaixarProdutoToolStripMenuItem";
            adcionarbaixarProdutoToolStripMenuItem.Size = new Size(230, 22);
            adcionarbaixarProdutoToolStripMenuItem.Text = "Adcionar/baixar Produto";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarCategoriaToolStripMenuItem, cadastrarFornecedoresToolStripMenuItem, cadastrarMarcasToolStripMenuItem, cadastrarProdutoToolStripMenuItem, toolStripMenuItem2, cadastrarUsuariosToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // cadastrarCategoriaToolStripMenuItem
            // 
            cadastrarCategoriaToolStripMenuItem.Name = "cadastrarCategoriaToolStripMenuItem";
            cadastrarCategoriaToolStripMenuItem.Size = new Size(198, 22);
            cadastrarCategoriaToolStripMenuItem.Text = "Cadastrar Categoria";
            cadastrarCategoriaToolStripMenuItem.Click += cadastrarCategoriaToolStripMenuItem_Click;
            // 
            // cadastrarFornecedoresToolStripMenuItem
            // 
            cadastrarFornecedoresToolStripMenuItem.Name = "cadastrarFornecedoresToolStripMenuItem";
            cadastrarFornecedoresToolStripMenuItem.Size = new Size(198, 22);
            cadastrarFornecedoresToolStripMenuItem.Text = "Cadastrar Fornecedores";
            cadastrarFornecedoresToolStripMenuItem.Click += cadastrarFornecedoresToolStripMenuItem_Click;
            // 
            // cadastrarMarcasToolStripMenuItem
            // 
            cadastrarMarcasToolStripMenuItem.Name = "cadastrarMarcasToolStripMenuItem";
            cadastrarMarcasToolStripMenuItem.Size = new Size(198, 22);
            cadastrarMarcasToolStripMenuItem.Text = "Cadastrar Marcas";
            cadastrarMarcasToolStripMenuItem.Click += cadastrarMarcasToolStripMenuItem_Click;
            // 
            // cadastrarProdutoToolStripMenuItem
            // 
            cadastrarProdutoToolStripMenuItem.Name = "cadastrarProdutoToolStripMenuItem";
            cadastrarProdutoToolStripMenuItem.Size = new Size(198, 22);
            cadastrarProdutoToolStripMenuItem.Text = "Cadastrar Produto";
            cadastrarProdutoToolStripMenuItem.Click += cadastrarProdutoToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(195, 6);
            // 
            // cadastrarUsuariosToolStripMenuItem
            // 
            cadastrarUsuariosToolStripMenuItem.Name = "cadastrarUsuariosToolStripMenuItem";
            cadastrarUsuariosToolStripMenuItem.Size = new Size(198, 22);
            cadastrarUsuariosToolStripMenuItem.Text = "Cadastrar Usuarios";
            cadastrarUsuariosToolStripMenuItem.Click += cadastrarUsuariosToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem, fecharToolStripMenuItem });
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(112, 22);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // fecharToolStripMenuItem
            // 
            fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            fecharToolStripMenuItem.Size = new Size(112, 22);
            fecharToolStripMenuItem.Text = "Fechar";
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1375, 646);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmMenu";
            Text = "Estoque LPJMN";
            Load += FrmMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem gerirProdutosToolStripMenuItem;
        private ToolStripMenuItem gerirProdutosToolStripMenuItem1;
        private ToolStripMenuItem verificarValidadeDeProdutosToolStripMenuItem;
        private ToolStripMenuItem adcionarbaixarProdutoToolStripMenuItem;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem cadastrarCategoriaToolStripMenuItem;
        private ToolStripMenuItem cadastrarFornecedoresToolStripMenuItem;
        private ToolStripMenuItem cadastrarMarcasToolStripMenuItem;
        private ToolStripMenuItem cadastrarUsuariosToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem cadastrarProdutoToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem fecharToolStripMenuItem;
    }
}
