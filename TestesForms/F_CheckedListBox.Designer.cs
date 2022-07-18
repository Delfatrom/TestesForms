namespace TestesForms
{
    partial class F_CheckedListBox
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
            this.clb_veiculos = new System.Windows.Forms.CheckedListBox();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.tb_veiculo = new System.Windows.Forms.TextBox();
            this.btn_mostrarselecionados = new System.Windows.Forms.Button();
            this.btn_resetarselecionados = new System.Windows.Forms.Button();
            this.btn_resetarlista = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clb_veiculos
            // 
            this.clb_veiculos.FormattingEnabled = true;
            this.clb_veiculos.Items.AddRange(new object[] {
            "Avião",
            "Carro",
            "Ônibus"});
            this.clb_veiculos.Location = new System.Drawing.Point(26, 39);
            this.clb_veiculos.Name = "clb_veiculos";
            this.clb_veiculos.Size = new System.Drawing.Size(178, 229);
            this.clb_veiculos.TabIndex = 0;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(223, 76);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(111, 47);
            this.btn_adicionar.TabIndex = 1;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(340, 76);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(111, 47);
            this.btn_remover.TabIndex = 1;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // tb_veiculo
            // 
            this.tb_veiculo.Location = new System.Drawing.Point(223, 50);
            this.tb_veiculo.Name = "tb_veiculo";
            this.tb_veiculo.Size = new System.Drawing.Size(228, 20);
            this.tb_veiculo.TabIndex = 2;
            this.tb_veiculo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_veiculo_KeyDown);
            // 
            // btn_mostrarselecionados
            // 
            this.btn_mostrarselecionados.Location = new System.Drawing.Point(223, 142);
            this.btn_mostrarselecionados.Name = "btn_mostrarselecionados";
            this.btn_mostrarselecionados.Size = new System.Drawing.Size(228, 35);
            this.btn_mostrarselecionados.TabIndex = 3;
            this.btn_mostrarselecionados.Text = "Mostrar Selecionados";
            this.btn_mostrarselecionados.UseVisualStyleBackColor = true;
            this.btn_mostrarselecionados.Click += new System.EventHandler(this.btn_mostrarselecionados_Click);
            // 
            // btn_resetarselecionados
            // 
            this.btn_resetarselecionados.Location = new System.Drawing.Point(223, 183);
            this.btn_resetarselecionados.Name = "btn_resetarselecionados";
            this.btn_resetarselecionados.Size = new System.Drawing.Size(228, 35);
            this.btn_resetarselecionados.TabIndex = 3;
            this.btn_resetarselecionados.Text = "Resetar Selecionados";
            this.btn_resetarselecionados.UseVisualStyleBackColor = true;
            this.btn_resetarselecionados.Click += new System.EventHandler(this.btn_resetarlista_Click);
            // 
            // btn_resetarlista
            // 
            this.btn_resetarlista.Location = new System.Drawing.Point(223, 224);
            this.btn_resetarlista.Name = "btn_resetarlista";
            this.btn_resetarlista.Size = new System.Drawing.Size(228, 35);
            this.btn_resetarlista.TabIndex = 3;
            this.btn_resetarlista.Text = "Resetar Lista";
            this.btn_resetarlista.UseVisualStyleBackColor = true;
            this.btn_resetarlista.Click += new System.EventHandler(this.btn_resetarlista_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Veículos";
            // 
            // F_CheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 290);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_resetarlista);
            this.Controls.Add(this.btn_resetarselecionados);
            this.Controls.Add(this.btn_mostrarselecionados);
            this.Controls.Add(this.tb_veiculo);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.clb_veiculos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_CheckedListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckedListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb_veiculos;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.TextBox tb_veiculo;
        private System.Windows.Forms.Button btn_mostrarselecionados;
        private System.Windows.Forms.Button btn_resetarselecionados;
        private System.Windows.Forms.Button btn_resetarlista;
        private System.Windows.Forms.Label label1;
    }
}