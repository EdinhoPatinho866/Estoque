namespace Dados
{
    partial class FrmUsuario
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
            ckbCadPro = new CheckBox();
            CkbCadCat = new CheckBox();
            CkbAddPro = new CheckBox();
            CkbCadUsuario = new CheckBox();
            CkbADM = new CheckBox();
            txtNome = new TextBox();
            txtSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BtnSalvar = new Button();
            BtnSair = new Button();
            txtID = new TextBox();
            label4 = new Label();
            ckbMarcas = new CheckBox();
            CkbFornecedor = new CheckBox();
            GrdItem = new DataGridView();
            ID2 = new DataGridViewTextBoxColumn();
            Nome2 = new DataGridViewTextBoxColumn();
            CadProd = new DataGridViewTextBoxColumn();
            CadCate = new DataGridViewTextBoxColumn();
            AddRemProd = new DataGridViewTextBoxColumn();
            CadUsua = new DataGridViewTextBoxColumn();
            CadMarc = new DataGridViewTextBoxColumn();
            CadForn = new DataGridViewTextBoxColumn();
            PerADM = new DataGridViewTextBoxColumn();
            AlterarUsuarios = new DataGridViewButtonColumn();
            ExcluirUsuarios = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)GrdItem).BeginInit();
            SuspendLayout();
            // 
            // ckbCadPro
            // 
            ckbCadPro.AutoSize = true;
            ckbCadPro.Location = new Point(21, 101);
            ckbCadPro.Name = "ckbCadPro";
            ckbCadPro.Size = new Size(127, 19);
            ckbCadPro.TabIndex = 0;
            ckbCadPro.Text = "Cadastrar produtos";
            ckbCadPro.UseVisualStyleBackColor = true;
            ckbCadPro.CheckedChanged += ckbCadPro_CheckedChanged;
            // 
            // CkbCadCat
            // 
            CkbCadCat.AutoSize = true;
            CkbCadCat.Location = new Point(166, 101);
            CkbCadCat.Name = "CkbCadCat";
            CkbCadCat.Size = new Size(135, 19);
            CkbCadCat.TabIndex = 1;
            CkbCadCat.Text = "Cadastrar Categorias";
            CkbCadCat.UseVisualStyleBackColor = true;
            CkbCadCat.CheckedChanged += CkbCadCat_CheckedChanged;
            // 
            // CkbAddPro
            // 
            CkbAddPro.AutoSize = true;
            CkbAddPro.Location = new Point(323, 101);
            CkbAddPro.Name = "CkbAddPro";
            CkbAddPro.Size = new Size(181, 19);
            CkbAddPro.TabIndex = 2;
            CkbAddPro.Text = "Adcionar e remover produtos";
            CkbAddPro.UseVisualStyleBackColor = true;
            CkbAddPro.CheckedChanged += CkbAddPro_CheckedChanged;
            // 
            // CkbCadUsuario
            // 
            CkbCadUsuario.AutoSize = true;
            CkbCadUsuario.Location = new Point(510, 101);
            CkbCadUsuario.Name = "CkbCadUsuario";
            CkbCadUsuario.Size = new Size(118, 19);
            CkbCadUsuario.TabIndex = 3;
            CkbCadUsuario.Text = "Cadastrar usuario";
            CkbCadUsuario.UseVisualStyleBackColor = true;
            CkbCadUsuario.CheckedChanged += CkbCadUsuario_CheckedChanged;
            // 
            // CkbADM
            // 
            CkbADM.AutoSize = true;
            CkbADM.Location = new Point(910, 101);
            CkbADM.Name = "CkbADM";
            CkbADM.Size = new Size(53, 19);
            CkbADM.TabIndex = 4;
            CkbADM.Text = "ADM";
            CkbADM.UseVisualStyleBackColor = true;
            CkbADM.CheckedChanged += CkbADM_CheckedChanged;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(182, 39);
            txtNome.MaxLength = 60;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(566, 23);
            txtNome.TabIndex = 5;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(754, 39);
            txtSenha.MaxLength = 50;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(411, 23);
            txtSenha.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(182, 21);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 7;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(754, 21);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 8;
            label2.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 76);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 9;
            label3.Text = "Permissões";
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(12, 149);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(124, 44);
            BtnSalvar.TabIndex = 11;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnSair
            // 
            BtnSair.Location = new Point(1041, 149);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(124, 44);
            BtnSair.TabIndex = 12;
            BtnSair.Text = "Fechar";
            BtnSair.UseVisualStyleBackColor = true;
            BtnSair.Click += BtnSair_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(12, 39);
            txtID.MaxLength = 4;
            txtID.Name = "txtID";
            txtID.Size = new Size(164, 23);
            txtID.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 21);
            label4.Name = "label4";
            label4.Size = new Size(18, 15);
            label4.TabIndex = 14;
            label4.Text = "ID";
            // 
            // ckbMarcas
            // 
            ckbMarcas.AutoSize = true;
            ckbMarcas.Location = new Point(634, 101);
            ckbMarcas.Name = "ckbMarcas";
            ckbMarcas.Size = new Size(117, 19);
            ckbMarcas.TabIndex = 15;
            ckbMarcas.Text = "Cadastrar Marcas";
            ckbMarcas.UseVisualStyleBackColor = true;
            ckbMarcas.CheckedChanged += ckbMarcas_CheckedChanged;
            // 
            // CkbFornecedor
            // 
            CkbFornecedor.AutoSize = true;
            CkbFornecedor.Location = new Point(754, 101);
            CkbFornecedor.Name = "CkbFornecedor";
            CkbFornecedor.Size = new Size(150, 19);
            CkbFornecedor.TabIndex = 16;
            CkbFornecedor.Text = "Cadastrar Fornecedores";
            CkbFornecedor.UseVisualStyleBackColor = true;
            CkbFornecedor.CheckedChanged += CkbFornecedor_CheckedChanged;
            // 
            // GrdItem
            // 
            GrdItem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GrdItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdItem.Columns.AddRange(new DataGridViewColumn[] { ID2, Nome2, CadProd, CadCate, AddRemProd, CadUsua, CadMarc, CadForn, PerADM, AlterarUsuarios, ExcluirUsuarios });
            GrdItem.Location = new Point(12, 199);
            GrdItem.Name = "GrdItem";
            GrdItem.Size = new Size(1153, 406);
            GrdItem.TabIndex = 17;
            GrdItem.CellClick += GrdItem_CellClick;
            GrdItem.CellContentClick += GrdItem_CellContentClick;
            // 
            // ID2
            // 
            ID2.DataPropertyName = "ID";
            ID2.HeaderText = "Id";
            ID2.Name = "ID2";
            // 
            // Nome2
            // 
            Nome2.DataPropertyName = "Nome";
            Nome2.HeaderText = "Nome";
            Nome2.Name = "Nome2";
            // 
            // CadProd
            // 
            CadProd.DataPropertyName = "CadPro";
            CadProd.HeaderText = "Cad. Produto";
            CadProd.Name = "CadProd";
            // 
            // CadCate
            // 
            CadCate.DataPropertyName = "CadCat";
            CadCate.HeaderText = "Cad. Categoria";
            CadCate.Name = "CadCate";
            // 
            // AddRemProd
            // 
            AddRemProd.DataPropertyName = "PAddPro";
            AddRemProd.HeaderText = "Add/Rem Produtos";
            AddRemProd.Name = "AddRemProd";
            // 
            // CadUsua
            // 
            CadUsua.DataPropertyName = "CadUsuario";
            CadUsua.HeaderText = "Cad. Usuarios";
            CadUsua.Name = "CadUsua";
            // 
            // CadMarc
            // 
            CadMarc.DataPropertyName = "CadMarca";
            CadMarc.HeaderText = "Cad. Marcas";
            CadMarc.Name = "CadMarc";
            // 
            // CadForn
            // 
            CadForn.DataPropertyName = "CadFor";
            CadForn.HeaderText = "Cad. Fornecedores";
            CadForn.Name = "CadForn";
            // 
            // PerADM
            // 
            PerADM.DataPropertyName = "PADM";
            PerADM.HeaderText = "ADM";
            PerADM.Name = "PerADM";
            // 
            // AlterarUsuarios
            // 
            AlterarUsuarios.HeaderText = "Editar";
            AlterarUsuarios.Name = "AlterarUsuarios";
            // 
            // ExcluirUsuarios
            // 
            ExcluirUsuarios.HeaderText = "Excluir";
            ExcluirUsuarios.Name = "ExcluirUsuarios";
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 617);
            Controls.Add(GrdItem);
            Controls.Add(CkbFornecedor);
            Controls.Add(ckbMarcas);
            Controls.Add(label4);
            Controls.Add(txtID);
            Controls.Add(BtnSair);
            Controls.Add(BtnSalvar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSenha);
            Controls.Add(txtNome);
            Controls.Add(CkbADM);
            Controls.Add(CkbCadUsuario);
            Controls.Add(CkbAddPro);
            Controls.Add(CkbCadCat);
            Controls.Add(ckbCadPro);
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            Load += FrmUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)GrdItem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox ckbCadPro;
        private CheckBox CkbCadCat;
        private CheckBox CkbAddPro;
        private CheckBox CkbCadUsuario;
        private CheckBox CkbADM;
        private TextBox txtNome;
        private TextBox txtSenha;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button BtnSalvar;
        private Button BtnSair;
        private TextBox txtID;
        private Label label4;
        private CheckBox ckbMarcas;
        private CheckBox CkbFornecedor;
        private DataGridView GrdItem;
        private DataGridViewTextBoxColumn ID2;
        private DataGridViewTextBoxColumn Nome2;
        private DataGridViewTextBoxColumn CadProd;
        private DataGridViewTextBoxColumn CadCate;
        private DataGridViewTextBoxColumn AddRemProd;
        private DataGridViewTextBoxColumn CadUsua;
        private DataGridViewTextBoxColumn CadMarc;
        private DataGridViewTextBoxColumn CadForn;
        private DataGridViewTextBoxColumn PerADM;
        private DataGridViewButtonColumn AlterarUsuarios;
        private DataGridViewButtonColumn ExcluirUsuarios;
    }
}