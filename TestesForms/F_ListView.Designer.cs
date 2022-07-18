namespace TestesForms
{
    partial class F_ListView
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Avião",
            "130",
            "5000,00"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Carro",
            "200",
            "2000,00"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "3",
            "Ônibus",
            "30",
            "1000,00"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "4",
            "Trem",
            "50",
            "4000,00"}, -1);
            this.lv_veiculos = new System.Windows.Forms.ListView();
            this.coluna_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_veiculo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_quantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coluna_preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_veiculos = new System.Windows.Forms.TextBox();
            this.tb_quantidade = new System.Windows.Forms.TextBox();
            this.tb_preco = new System.Windows.Forms.TextBox();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_obter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lv_veiculos
            // 
            this.lv_veiculos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coluna_ID,
            this.coluna_veiculo,
            this.coluna_quantidade,
            this.coluna_preco});
            this.lv_veiculos.FullRowSelect = true;
            this.lv_veiculos.HideSelection = false;
            listViewItem4.Tag = "Trem";
            this.lv_veiculos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.lv_veiculos.Location = new System.Drawing.Point(12, 23);
            this.lv_veiculos.MultiSelect = false;
            this.lv_veiculos.Name = "lv_veiculos";
            this.lv_veiculos.Size = new System.Drawing.Size(349, 157);
            this.lv_veiculos.TabIndex = 0;
            this.lv_veiculos.TabStop = false;
            this.lv_veiculos.UseCompatibleStateImageBehavior = false;
            this.lv_veiculos.View = System.Windows.Forms.View.Details;
            this.lv_veiculos.SelectedIndexChanged += new System.EventHandler(this.lv_veiculos_SelectedIndexChanged);
            // 
            // coluna_ID
            // 
            this.coluna_ID.Text = "ID";
            this.coluna_ID.Width = 30;
            // 
            // coluna_veiculo
            // 
            this.coluna_veiculo.Text = "Veículo";
            this.coluna_veiculo.Width = 138;
            // 
            // coluna_quantidade
            // 
            this.coluna_quantidade.Text = "Quantidade";
            this.coluna_quantidade.Width = 75;
            // 
            // coluna_preco
            // 
            this.coluna_preco.Text = "Preço";
            this.coluna_preco.Width = 99;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(12, 215);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(50, 20);
            this.tb_id.TabIndex = 0;
            this.tb_id.TabStop = false;
            // 
            // tb_veiculos
            // 
            this.tb_veiculos.Location = new System.Drawing.Point(68, 215);
            this.tb_veiculos.Name = "tb_veiculos";
            this.tb_veiculos.Size = new System.Drawing.Size(128, 20);
            this.tb_veiculos.TabIndex = 1;
            // 
            // tb_quantidade
            // 
            this.tb_quantidade.Location = new System.Drawing.Point(202, 215);
            this.tb_quantidade.Name = "tb_quantidade";
            this.tb_quantidade.Size = new System.Drawing.Size(72, 20);
            this.tb_quantidade.TabIndex = 2;
            // 
            // tb_preco
            // 
            this.tb_preco.Location = new System.Drawing.Point(280, 215);
            this.tb_preco.Name = "tb_preco";
            this.tb_preco.Size = new System.Drawing.Size(81, 20);
            this.tb_preco.TabIndex = 3;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(117, 267);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(132, 31);
            this.btn_adicionar.TabIndex = 3;
            this.btn_adicionar.TabStop = false;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(117, 304);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(132, 31);
            this.btn_remover.TabIndex = 3;
            this.btn_remover.TabStop = false;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_obter
            // 
            this.btn_obter.Location = new System.Drawing.Point(117, 341);
            this.btn_obter.Name = "btn_obter";
            this.btn_obter.Size = new System.Drawing.Size(132, 31);
            this.btn_obter.TabIndex = 3;
            this.btn_obter.TabStop = false;
            this.btn_obter.Text = "Obter";
            this.btn_obter.UseVisualStyleBackColor = true;
            this.btn_obter.Click += new System.EventHandler(this.btn_obter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Veículo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Preço:";
            // 
            // F_ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 409);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_obter);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.tb_preco);
            this.Controls.Add(this.tb_quantidade);
            this.Controls.Add(this.tb_veiculos);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.lv_veiculos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_ListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_veiculos;
        private System.Windows.Forms.ColumnHeader coluna_ID;
        private System.Windows.Forms.ColumnHeader coluna_veiculo;
        private System.Windows.Forms.ColumnHeader coluna_quantidade;
        private System.Windows.Forms.ColumnHeader coluna_preco;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_veiculos;
        private System.Windows.Forms.TextBox tb_quantidade;
        private System.Windows.Forms.TextBox tb_preco;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_obter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}