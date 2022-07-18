namespace TestesForms
{
    partial class F_ComboBox
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
            this.cb_veiculos = new System.Windows.Forms.ComboBox();
            this.btn_MostrarSelecionado = new System.Windows.Forms.Button();
            this.btn_limparveiculos = new System.Windows.Forms.Button();
            this.btn_resetarveiculos = new System.Windows.Forms.Button();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.tb_veiculos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_veiculos
            // 
            this.cb_veiculos.FormattingEnabled = true;
            this.cb_veiculos.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cb_veiculos.Items.AddRange(new object[] {
            "Avião",
            "Carro",
            "Ônibus",
            "Trem"});
            this.cb_veiculos.Location = new System.Drawing.Point(22, 27);
            this.cb_veiculos.Name = "cb_veiculos";
            this.cb_veiculos.Size = new System.Drawing.Size(172, 21);
            this.cb_veiculos.TabIndex = 0;
            this.cb_veiculos.SelectedIndexChanged += new System.EventHandler(this.cb_veiculos_SelectedIndexChanged);
            // 
            // btn_MostrarSelecionado
            // 
            this.btn_MostrarSelecionado.Location = new System.Drawing.Point(235, 20);
            this.btn_MostrarSelecionado.Name = "btn_MostrarSelecionado";
            this.btn_MostrarSelecionado.Size = new System.Drawing.Size(172, 33);
            this.btn_MostrarSelecionado.TabIndex = 1;
            this.btn_MostrarSelecionado.Text = "Mostrar Selecionado";
            this.btn_MostrarSelecionado.UseVisualStyleBackColor = true;
            this.btn_MostrarSelecionado.Click += new System.EventHandler(this.btn_MostrarSelecionados_Click);
            // 
            // btn_limparveiculos
            // 
            this.btn_limparveiculos.Location = new System.Drawing.Point(236, 59);
            this.btn_limparveiculos.Name = "btn_limparveiculos";
            this.btn_limparveiculos.Size = new System.Drawing.Size(172, 33);
            this.btn_limparveiculos.TabIndex = 1;
            this.btn_limparveiculos.Text = "Limpar Veículos";
            this.btn_limparveiculos.UseVisualStyleBackColor = true;
            this.btn_limparveiculos.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_resetarveiculos
            // 
            this.btn_resetarveiculos.Location = new System.Drawing.Point(235, 98);
            this.btn_resetarveiculos.Name = "btn_resetarveiculos";
            this.btn_resetarveiculos.Size = new System.Drawing.Size(172, 33);
            this.btn_resetarveiculos.TabIndex = 1;
            this.btn_resetarveiculos.Text = "Resetar Veículos";
            this.btn_resetarveiculos.UseVisualStyleBackColor = true;
            this.btn_resetarveiculos.Click += new System.EventHandler(this.btn_ResetarElementos_Click);
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Location = new System.Drawing.Point(235, 137);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(172, 33);
            this.btn_Adicionar.TabIndex = 1;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // tb_veiculos
            // 
            this.tb_veiculos.Location = new System.Drawing.Point(22, 144);
            this.tb_veiculos.Name = "tb_veiculos";
            this.tb_veiculos.Size = new System.Drawing.Size(172, 20);
            this.tb_veiculos.TabIndex = 2;
            this.tb_veiculos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_veiculos_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite o veiculo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Veículos";
            // 
            // F_ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 201);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_veiculos);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.btn_resetarveiculos);
            this.Controls.Add(this.btn_limparveiculos);
            this.Controls.Add(this.btn_MostrarSelecionado);
            this.Controls.Add(this.cb_veiculos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_ComboBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Combo Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_veiculos;
        private System.Windows.Forms.Button btn_MostrarSelecionado;
        private System.Windows.Forms.Button btn_limparveiculos;
        private System.Windows.Forms.Button btn_resetarveiculos;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.TextBox tb_veiculos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}