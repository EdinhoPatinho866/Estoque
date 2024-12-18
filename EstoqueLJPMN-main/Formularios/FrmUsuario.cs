﻿using Dados.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dados
{
    public partial class FrmUsuario : Form
    {
        private int RegProd;
        private int RegCat;
        private int AddProd;
        private int RegUsuario;
        private int RegMarca;
        private int RegFornecedor;
        private int ADM;

        private bool incluir = true;
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void ckbCadPro_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbCadPro.Checked == true)
            {
                RegProd = 1;
            }
            else
            {
                RegProd = 0;
            }
        }

        private void CkbCadCat_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbCadCat.Checked == true)
            {
                RegCat = 1;
            }
            else
            {
                RegCat = 0;
            }
        }

        private void CkbAddPro_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbAddPro.Checked == true)
            {
                AddProd = 1;
            }
            else
            {
                AddProd = 0;
            }
        }

        private void CkbCadUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbCadUsuario.Checked == true)
            {
                RegUsuario = 1;
            }
            else
            {
                RegUsuario = 0;
            }
        }

        private void ckbMarcas_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMarcas.Checked == true)
            {
                RegMarca = 1;
            }
            else
            {
                RegMarca = 0;
            }
        }

        private void CkbFornecedor_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbFornecedor.Checked == true)
            {
                RegFornecedor = 1;
            }
            else
            {
                RegFornecedor = 0;
            }
        }

        private void CkbADM_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbADM.Checked == true)
            {
                ADM = 1;
                CkbAddPro.Checked = false;
                CkbAddPro.Enabled = false;
                CkbCadCat.Checked = false;
                CkbCadCat.Enabled = false;
                CkbCadUsuario.Checked = false;
                CkbCadUsuario.Enabled = false;
                CkbFornecedor.Checked = false;
                CkbFornecedor.Enabled = false;
                ckbCadPro.Checked = false;
                ckbCadPro.Enabled = false;
                ckbMarcas.Checked = false;
                ckbMarcas.Enabled = false;
            }
            else
            {
                ADM = 0;
                CkbAddPro.Enabled = true;
                CkbCadCat.Enabled = true;
                CkbCadUsuario.Enabled = true;
                CkbFornecedor.Enabled = true;
                ckbCadPro.Enabled = true;
                ckbMarcas.Enabled = true;
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpaControles()
        {
            txtID.Text = "";
            txtNome.Text = "";
            txtSenha.Text = "";

        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void CarregaGrid()
        {

            GrdItem.AutoGenerateColumns = false;
            GrdItem.DataSource = Usuarios.ListarTodosUsuarios();

        }

        private void GrdItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private bool ValidaControles()
        {

            if (txtNome.Text.Trim() == "" && txtSenha.Text.Trim() == "")
            {
                MessageBox.Show("O campo nome e senha são obrigatorio.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
                return false;
            }


            return true;
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
            {
                if (incluir)
                {

                    Usuarios oUsuario = new Usuarios
                    {
                        Nome = txtNome.Text,
                        Senha = txtSenha.Text,

                        CadPro2 = RegProd,
                        CadCat2 = RegCat,
                        PAddPro2 = AddProd,
                        CadUsuario2 = RegUsuario,
                        CadMarca2 = RegMarca,
                        CadFor2 = RegFornecedor,
                        PADM2 = ADM,
                    };

                    try
                    {
                        oUsuario.Incluir();
                        CarregaGrid();
                        LimpaControles();
                        txtID.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu ao incluir o Usuario: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtID.Focus();
                    }
                }
                else
                {
                    try
                    {
                        Usuarios oUsuario = new Usuarios
                        {
                            Id = int.Parse(txtID.Text),
                            Nome = txtNome.Text,
                            Senha = txtSenha.Text,
                            CadPro2 = RegProd,
                            CadCat2 = RegCat,
                            PAddPro2 = AddProd,
                            CadUsuario2 = RegUsuario,
                            CadMarca2 = RegMarca,
                            CadFor2 = RegFornecedor,
                            PADM2 = ADM,

                        };
                        Usuarios.AlterarUsuario(oUsuario);
                        incluir = true;
                        LimpaControles();
                        CarregaGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Um erro ocorreu ao alterar o Usuario: {ex.Message}.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtID.Focus();
                    }

                }
            }
        }

        private void GrdItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdItem.Rows[e.RowIndex].DataBoundItem != null)
            {
                Usuarios ObjSelecionado = (Usuarios)GrdItem.Rows[e.RowIndex].DataBoundItem;

                if (GrdItem.Columns[e.ColumnIndex].Name == "AlterarUsuarios")
                {
                    txtID.Text = ObjSelecionado.Id.ToString();
                    txtNome.Text = ObjSelecionado.Nome;
                    txtID.Enabled = false;
                    txtNome.Focus();
                    incluir = false;
                }
                else if (GrdItem.Columns[e.ColumnIndex].Name == "ExcluirUsuarios")
                {
                    if (MessageBox.Show("Confirme a exclusao.", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ObjSelecionado.Excluir();
                        CarregaGrid();
                    }
                }
            }
        }
    }
}
