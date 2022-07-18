namespace TestesForms
{
    partial class F_NumericUpDown
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
            this.nud_valores = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_valores = new System.Windows.Forms.TextBox();
            this.btn_passarvalor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_valores)).BeginInit();
            this.SuspendLayout();
            // 
            // nud_valores
            // 
            this.nud_valores.Location = new System.Drawing.Point(34, 31);
            this.nud_valores.Name = "nud_valores";
            this.nud_valores.Size = new System.Drawing.Size(65, 20);
            this.nud_valores.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numeric";
            // 
            // tb_valores
            // 
            this.tb_valores.Location = new System.Drawing.Point(163, 31);
            this.tb_valores.Name = "tb_valores";
            this.tb_valores.Size = new System.Drawing.Size(65, 20);
            this.tb_valores.TabIndex = 2;
            this.tb_valores.Text = "0";
            // 
            // btn_passarvalor
            // 
            this.btn_passarvalor.Location = new System.Drawing.Point(234, 24);
            this.btn_passarvalor.Name = "btn_passarvalor";
            this.btn_passarvalor.Size = new System.Drawing.Size(80, 33);
            this.btn_passarvalor.TabIndex = 3;
            this.btn_passarvalor.Text = "Passar Valor";
            this.btn_passarvalor.UseVisualStyleBackColor = true;
            this.btn_passarvalor.Click += new System.EventHandler(this.btn_passarvalor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "<-------------";
            // 
            // F_NumericUpDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 89);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_passarvalor);
            this.Controls.Add(this.tb_valores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_valores);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_NumericUpDown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NumericUpDown";
            ((System.ComponentModel.ISupportInitialize)(this.nud_valores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nud_valores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_passarvalor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_valores;
    }
}