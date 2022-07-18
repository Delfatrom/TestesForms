namespace TestesForms
{
    partial class F_ProgressBar
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_preencher = new System.Windows.Forms.Button();
            this.btn_preenchervalor = new System.Windows.Forms.Button();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(10, 137);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(500, 35);
            this.progressBar1.TabIndex = 0;
            // 
            // btn_preencher
            // 
            this.btn_preencher.Location = new System.Drawing.Point(188, 178);
            this.btn_preencher.Name = "btn_preencher";
            this.btn_preencher.Size = new System.Drawing.Size(126, 37);
            this.btn_preencher.TabIndex = 1;
            this.btn_preencher.Text = "Preencher";
            this.btn_preencher.UseVisualStyleBackColor = true;
            // 
            // btn_preenchervalor
            // 
            this.btn_preenchervalor.Location = new System.Drawing.Point(214, 68);
            this.btn_preenchervalor.Name = "btn_preenchervalor";
            this.btn_preenchervalor.Size = new System.Drawing.Size(73, 31);
            this.btn_preenchervalor.TabIndex = 2;
            this.btn_preenchervalor.Text = "Definir Valor";
            this.btn_preenchervalor.UseVisualStyleBackColor = true;
            this.btn_preenchervalor.Click += new System.EventHandler(this.btn_preenchervalor_Click);
            // 
            // tb_valor
            // 
            this.tb_valor.Location = new System.Drawing.Point(188, 42);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(126, 20);
            this.tb_valor.TabIndex = 3;
            this.tb_valor.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Progress Bar";
            // 
            // F_ProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 253);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_valor);
            this.Controls.Add(this.btn_preenchervalor);
            this.Controls.Add(this.btn_preencher);
            this.Controls.Add(this.progressBar1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_ProgressBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgressBar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_preencher;
        private System.Windows.Forms.Button btn_preenchervalor;
        private System.Windows.Forms.TextBox tb_valor;
        private System.Windows.Forms.Label label1;
    }
}