namespace TestesForms
{
    partial class F_TabControl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_novaAba = new System.Windows.Forms.Button();
            this.btn_removerAba = new System.Windows.Forms.Button();
            this.tb_abas = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_acessarAba = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(554, 202);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(546, 176);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Primeira Aba";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(603, 176);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Segunda Aba";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_novaAba
            // 
            this.btn_novaAba.Location = new System.Drawing.Point(321, 242);
            this.btn_novaAba.Name = "btn_novaAba";
            this.btn_novaAba.Size = new System.Drawing.Size(75, 23);
            this.btn_novaAba.TabIndex = 1;
            this.btn_novaAba.Text = "Nova Aba";
            this.btn_novaAba.UseVisualStyleBackColor = true;
            this.btn_novaAba.Click += new System.EventHandler(this.btn_novaAba_Click);
            // 
            // btn_removerAba
            // 
            this.btn_removerAba.Location = new System.Drawing.Point(286, 278);
            this.btn_removerAba.Name = "btn_removerAba";
            this.btn_removerAba.Size = new System.Drawing.Size(75, 23);
            this.btn_removerAba.TabIndex = 2;
            this.btn_removerAba.Text = "Remover Aba";
            this.btn_removerAba.UseVisualStyleBackColor = true;
            this.btn_removerAba.Click += new System.EventHandler(this.btn_removerAba_Click);
            // 
            // tb_abas
            // 
            this.tb_abas.Location = new System.Drawing.Point(129, 243);
            this.tb_abas.Name = "tb_abas";
            this.tb_abas.Size = new System.Drawing.Size(186, 20);
            this.tb_abas.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(210, 279);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(70, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // btn_acessarAba
            // 
            this.btn_acessarAba.Location = new System.Drawing.Point(129, 278);
            this.btn_acessarAba.Name = "btn_acessarAba";
            this.btn_acessarAba.Size = new System.Drawing.Size(75, 23);
            this.btn_acessarAba.TabIndex = 5;
            this.btn_acessarAba.Text = "Acessar Aba";
            this.btn_acessarAba.UseVisualStyleBackColor = true;
            this.btn_acessarAba.Click += new System.EventHandler(this.btn_acessarAba_Click);
            // 
            // F_TabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 358);
            this.Controls.Add(this.btn_acessarAba);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.tb_abas);
            this.Controls.Add(this.btn_removerAba);
            this.Controls.Add(this.btn_novaAba);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_TabControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TabControl";
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_novaAba;
        private System.Windows.Forms.Button btn_removerAba;
        private System.Windows.Forms.TextBox tb_abas;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btn_acessarAba;
    }
}