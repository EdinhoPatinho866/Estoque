using Dados.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dados.Formularios
{
    public partial class FrmCadProdutos : Form
    {
        private bool incluir = true;
        public FrmCadProdutos()
        {
            InitializeComponent();
        }

        private void FrmCadProdutos_Load(object sender, EventArgs e)
        {
            CarregarCB();
            CarregaGrid();
        }

        private void CarregarCB()
        {
            CBCat.DataSource = Categoria.ListarTodos();
            CBCat.ValueMember = "Id";
            CBCat.DisplayMember = "Nome";
            CBMarca.DataSource = Marca.ListarTodos();
            CBMarca.ValueMember = "Id";
            CBMarca.DisplayMember = "Nome";
        }
        private void CarregaGrid()
        {

            GrdItens.AutoGenerateColumns = false;
            GrdItens.DataSource = Produto.ListarTodos();

        }

        private bool ValidaControles()
        {
            int Codigo;

            if (TxtNome.Text.Trim() == "")
            {
                MessageBox.Show("O campo nome é obrigatorio.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNome.Focus();
                return false;
            }

            return true;
        }

        private void LimpaControles()
        {
            TxtID.Text = "";
            TxtNome.Text = "";
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
            {
                if (incluir)
                {

                    Produto oProduto = new Produto
                    {
                        Nome = TxtNome.Text,
                        MarcaId2 = CBMarca.SelectedValue.ToString(),
                        CatId2 = CBCat.SelectedValue.ToString(),
                        Preco = float.Parse(TxtPreco.Text, System.Globalization.CultureInfo.InvariantCulture),
                        Barra = int.Parse(TxtBarra.Text),
                    };

                    try
                    {
                        oProduto.Incluir();
                        CarregaGrid();
                        LimpaControles();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu ao incluir o Produto: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtNome.Focus();
                    }
                }
                else
                {
                    try
                    {
                        Produto oProduto = new Produto
                        {
                            Id = int.Parse(TxtID.Text),
                            Nome = TxtNome.Text,
                            MarcaId2 = CBMarca.SelectedValue.ToString(),
                            CatId2 = CBCat.SelectedValue.ToString(),
                            Preco = float.Parse(TxtPreco.Text),
                            Barra = int.Parse(TxtBarra.Text),

                        };
                        Produto.AlterarProduto(oProduto);
                        incluir = true;
                        LimpaControles();
                        CarregaGrid();
                        TxtID.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu ao alterar o Produto: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtID.Focus();
                    }

                }
            }
        }

        private void GrdItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdItens.Rows[e.RowIndex].DataBoundItem != null)
            {
                Produto ObjSelecionado = (Produto)GrdItens.Rows[e.RowIndex].DataBoundItem;

                if (GrdItens.Columns[e.ColumnIndex].Name == "AlterarProduto")
                {
                    TxtID.Text = ObjSelecionado.Id.ToString();
                    TxtNome.Text = ObjSelecionado.Nome;
                    TxtPreco.Text = ObjSelecionado.Preco.ToString();
                    TxtBarra.Text = ObjSelecionado.Barra.ToString();
                    TxtID.Enabled = false;
                    TxtNome.Focus();
                    incluir = false;
                }
                else if (GrdItens.Columns[e.ColumnIndex].Name == "ExcluirProduto")
                {
                    if (MessageBox.Show("Confirme a exclusao.", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            ObjSelecionado.Excluir();
                            CarregaGrid();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Um erro ocorreu ao e excluir o Produto: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TxtID.Focus();
                        }
                    }
                }
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
