﻿namespace Dados.Formularios
{
    partial class FrmMarca
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
            BtnSalvar = new Button();
            BtnFechar = new Button();
            TxtID = new TextBox();
            TxtNome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            GrdItens = new DataGridView();
            IdMarca = new DataGridViewTextBoxColumn();
            NomeMarca = new DataGridViewTextBoxColumn();
            AlterarMarca = new DataGridViewButtonColumn();
            ExcluirMarca = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)GrdItens).BeginInit();
            SuspendLayout();
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(12, 63);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(133, 52);
            BtnSalvar.TabIndex = 0;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnFechar
            // 
            BtnFechar.Location = new Point(655, 63);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(133, 52);
            BtnFechar.TabIndex = 1;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // TxtID
            // 
            TxtID.Location = new Point(12, 34);
            TxtID.MaxLength = 4;
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(100, 23);
            TxtID.TabIndex = 2;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(118, 34);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(670, 23);
            TxtNome.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 4;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 16);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 5;
            label2.Text = "Marca";
            // 
            // GrdItens
            // 
            GrdItens.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GrdItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdItens.Columns.AddRange(new DataGridViewColumn[] { IdMarca, NomeMarca, AlterarMarca, ExcluirMarca });
            GrdItens.Location = new Point(12, 121);
            GrdItens.Name = "GrdItens";
            GrdItens.Size = new Size(776, 317);
            GrdItens.TabIndex = 6;
            GrdItens.CellClick += GrdItens_CellClick;
            GrdItens.CellContentClick += GrdItens_CellContentClick;
            // 
            // IdMarca
            // 
            IdMarca.DataPropertyName = "Id";
            IdMarca.HeaderText = "ID";
            IdMarca.Name = "IdMarca";
            // 
            // NomeMarca
            // 
            NomeMarca.DataPropertyName = "Nome";
            NomeMarca.HeaderText = "Marca";
            NomeMarca.Name = "NomeMarca";
            NomeMarca.Width = 430;
            // 
            // AlterarMarca
            // 
            AlterarMarca.HeaderText = "Alterar";
            AlterarMarca.Name = "AlterarMarca";
            // 
            // ExcluirMarca
            // 
            ExcluirMarca.HeaderText = "Excluir";
            ExcluirMarca.Name = "ExcluirMarca";
            // 
            // FrmMarca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GrdItens);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtNome);
            Controls.Add(TxtID);
            Controls.Add(BtnFechar);
            Controls.Add(BtnSalvar);
            Name = "FrmMarca";
            Text = "FrmMarca";
            Load += FrmMarca_Load;
            ((System.ComponentModel.ISupportInitialize)GrdItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSalvar;
        private Button BtnFechar;
        private TextBox TxtID;
        private TextBox TxtNome;
        private Label label1;
        private Label label2;
        private DataGridView GrdItens;
        private DataGridViewTextBoxColumn IdMarca;
        private DataGridViewTextBoxColumn NomeMarca;
        private DataGridViewButtonColumn AlterarMarca;
        private DataGridViewButtonColumn ExcluirMarca;
    }
}