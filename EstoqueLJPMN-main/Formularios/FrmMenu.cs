

using Dados.Formularios;

namespace Dados
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            if (FrmLogin.permissaoADM == 1)
            {

                if (FrmLogin.permissaoAddProd == 0)
                {
                    adcionarbaixarProdutoToolStripMenuItem.Enabled = false;
                };
                if (FrmLogin.permissaoCadUsuario == 0)
                {
                    cadastrarUsuariosToolStripMenuItem.Enabled = false;
                };
                if (FrmLogin.permissaoCadProd == 0)
                {
                    cadastrarProdutoToolStripMenuItem.Enabled = false;
                };
                if (FrmLogin.permissaoCadUsuario == 0)
                {

                };
                if (FrmLogin.permissaoCadUsuario == 0)
                {

                };
                if (FrmLogin.permissaoCadUsuario == 0)
                {

                };
            }
        }

        private void gerirProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGerir oFrm = new FrmGerir();
            oFrm.MdiParent = this;
            oFrm.Show();
        }

        private void cadastrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario oFrm = new FrmUsuario();
            oFrm.MdiParent = this;
            oFrm.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void cadastrarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria oFrm = new FrmCategoria();
            oFrm.MdiParent = this;
            oFrm.Show();

        }

        private void cadastrarMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMarca oFrm = new FrmMarca();
            oFrm.MdiParent = this;
            oFrm.Show();
        }

        private void cadastrarFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFornecedor oFrm = new FrmFornecedor();
            oFrm.MdiParent = this;
            oFrm.Show();
        }

        private void cadastrarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadProdutos oFrm = new FrmCadProdutos();
            oFrm.MdiParent = this;
            oFrm.Show();
        }
    }
}
