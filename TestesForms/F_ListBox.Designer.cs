namespace TestesForms
{
    partial class F_ListBox
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
            this.lb_veiculos = new System.Windows.Forms.ListBox();
            this.tb_digite = new System.Windows.Forms.TextBox();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_removerselecionado = new System.Windows.Forms.Button();
            this.btn_obter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_resetarlista = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_veiculos
            // 
            this.lb_veiculos.FormattingEnabled = true;
            this.lb_veiculos.Location = new System.Drawing.Point(24, 32);
            this.lb_veiculos.Name = "lb_veiculos";
            this.lb_veiculos.Size = new System.Drawing.Size(170, 238);
            this.lb_veiculos.TabIndex = 0;
            // 
            // tb_digite
            // 
            this.tb_digite.Location = new System.Drawing.Point(200, 61);
            this.tb_digite.Name = "tb_digite";
            this.tb_digite.Size = new System.Drawing.Size(121, 20);
            this.tb_digite.TabIndex = 1;
            this.tb_digite.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_digite_KeyDown);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(200, 90);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(120, 29);
            this.btn_adicionar.TabIndex = 2;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_removerselecionado
            // 
            this.btn_removerselecionado.Location = new System.Drawing.Point(200, 125);
            this.btn_removerselecionado.Name = "btn_removerselecionado";
            this.btn_removerselecionado.Size = new System.Drawing.Size(120, 29);
            this.btn_removerselecionado.TabIndex = 2;
            this.btn_removerselecionado.Text = "Remover Selecionado";
            this.btn_removerselecionado.UseVisualStyleBackColor = true;
            this.btn_removerselecionado.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_obter
            // 
            this.btn_obter.Location = new System.Drawing.Point(201, 195);
            this.btn_obter.Name = "btn_obter";
            this.btn_obter.Size = new System.Drawing.Size(120, 29);
            this.btn_obter.TabIndex = 2;
            this.btn_obter.Text = "Obter";
            this.btn_obter.UseVisualStyleBackColor = true;
            this.btn_obter.Click += new System.EventHandler(this.btn_obter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite:";
            // 
            // btn_resetarlista
            // 
            this.btn_resetarlista.Location = new System.Drawing.Point(200, 160);
            this.btn_resetarlista.Name = "btn_resetarlista";
            this.btn_resetarlista.Size = new System.Drawing.Size(120, 29);
            this.btn_resetarlista.TabIndex = 2;
            this.btn_resetarlista.Text = "Resetar Lista";
            this.btn_resetarlista.UseVisualStyleBackColor = true;
            this.btn_resetarlista.Click += new System.EventHandler(this.btn_resetarlista_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Veículos";
            // 
            // F_ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 297);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_obter);
            this.Controls.Add(this.btn_resetarlista);
            this.Controls.Add(this.btn_removerselecionado);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.tb_digite);
            this.Controls.Add(this.lb_veiculos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_ListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_veiculos;
        private System.Windows.Forms.TextBox tb_digite;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_removerselecionado;
        private System.Windows.Forms.Button btn_obter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_resetarlista;
        private System.Windows.Forms.Label label2;
    }
}