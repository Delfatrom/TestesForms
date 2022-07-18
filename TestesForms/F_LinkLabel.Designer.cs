namespace TestesForms
{
    partial class F_LinkLabel
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
            this.lbl_Digite = new System.Windows.Forms.Label();
            this.tb_link = new System.Windows.Forms.TextBox();
            this.ll_calculadora = new System.Windows.Forms.LinkLabel();
            this.ll_varioslinks = new System.Windows.Forms.LinkLabel();
            this.btn_acessar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Digite
            // 
            this.lbl_Digite.AutoSize = true;
            this.lbl_Digite.Location = new System.Drawing.Point(16, 17);
            this.lbl_Digite.Name = "lbl_Digite";
            this.lbl_Digite.Size = new System.Drawing.Size(150, 13);
            this.lbl_Digite.TabIndex = 0;
            this.lbl_Digite.Text = "Digite o link que quer acessar:";
            // 
            // tb_link
            // 
            this.tb_link.Location = new System.Drawing.Point(19, 33);
            this.tb_link.Name = "tb_link";
            this.tb_link.Size = new System.Drawing.Size(295, 20);
            this.tb_link.TabIndex = 1;
            // 
            // ll_calculadora
            // 
            this.ll_calculadora.AutoSize = true;
            this.ll_calculadora.Location = new System.Drawing.Point(204, 125);
            this.ll_calculadora.Name = "ll_calculadora";
            this.ll_calculadora.Size = new System.Drawing.Size(63, 13);
            this.ll_calculadora.TabIndex = 2;
            this.ll_calculadora.TabStop = true;
            this.ll_calculadora.Text = "Calculadora";
            this.ll_calculadora.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_calculadora_LinkClicked);
            // 
            // ll_varioslinks
            // 
            this.ll_varioslinks.AutoSize = true;
            this.ll_varioslinks.Location = new System.Drawing.Point(167, 166);
            this.ll_varioslinks.Name = "ll_varioslinks";
            this.ll_varioslinks.Size = new System.Drawing.Size(147, 13);
            this.ll_varioslinks.TabIndex = 3;
            this.ll_varioslinks.TabStop = true;
            this.ll_varioslinks.Text = "Google - Youtube - Facebook";
            this.ll_varioslinks.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_varioslinks_LinkClicked);
            // 
            // btn_acessar
            // 
            this.btn_acessar.Location = new System.Drawing.Point(109, 59);
            this.btn_acessar.Name = "btn_acessar";
            this.btn_acessar.Size = new System.Drawing.Size(105, 27);
            this.btn_acessar.TabIndex = 4;
            this.btn_acessar.Text = "Acessar";
            this.btn_acessar.UseVisualStyleBackColor = true;
            this.btn_acessar.Click += new System.EventHandler(this.btn_acessar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Acessar a calculadora do windows:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Acessar sites conhecidos:";
            // 
            // F_LinkLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 213);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_acessar);
            this.Controls.Add(this.ll_varioslinks);
            this.Controls.Add(this.ll_calculadora);
            this.Controls.Add(this.tb_link);
            this.Controls.Add(this.lbl_Digite);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_LinkLabel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LinkLabel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Digite;
        private System.Windows.Forms.TextBox tb_link;
        private System.Windows.Forms.LinkLabel ll_calculadora;
        private System.Windows.Forms.LinkLabel ll_varioslinks;
        private System.Windows.Forms.Button btn_acessar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}