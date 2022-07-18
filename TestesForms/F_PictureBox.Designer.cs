namespace TestesForms
{
    partial class F_PictureBox
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
            this.pb_cima = new System.Windows.Forms.PictureBox();
            this.btn_mudar = new System.Windows.Forms.Button();
            this.pb_baixo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_cima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_baixo)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_cima
            // 
            this.pb_cima.Image = global::TestesForms.Properties.Resources.img_capturar;
            this.pb_cima.InitialImage = global::TestesForms.Properties.Resources.img_capturar;
            this.pb_cima.Location = new System.Drawing.Point(12, 12);
            this.pb_cima.Name = "pb_cima";
            this.pb_cima.Size = new System.Drawing.Size(233, 173);
            this.pb_cima.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_cima.TabIndex = 0;
            this.pb_cima.TabStop = false;
            // 
            // btn_mudar
            // 
            this.btn_mudar.Location = new System.Drawing.Point(50, 191);
            this.btn_mudar.Name = "btn_mudar";
            this.btn_mudar.Size = new System.Drawing.Size(141, 23);
            this.btn_mudar.TabIndex = 1;
            this.btn_mudar.Text = "Mudar Imagem";
            this.btn_mudar.UseVisualStyleBackColor = true;
            this.btn_mudar.Click += new System.EventHandler(this.btn_mudar_Click);
            // 
            // pb_baixo
            // 
            this.pb_baixo.InitialImage = global::TestesForms.Properties.Resources.img_capturar;
            this.pb_baixo.Location = new System.Drawing.Point(12, 220);
            this.pb_baixo.Name = "pb_baixo";
            this.pb_baixo.Size = new System.Drawing.Size(233, 173);
            this.pb_baixo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_baixo.TabIndex = 0;
            this.pb_baixo.TabStop = false;
            // 
            // F_PictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 450);
            this.Controls.Add(this.btn_mudar);
            this.Controls.Add(this.pb_baixo);
            this.Controls.Add(this.pb_cima);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_PictureBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PictureBox";
            ((System.ComponentModel.ISupportInitialize)(this.pb_cima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_baixo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_cima;
        private System.Windows.Forms.Button btn_mudar;
        private System.Windows.Forms.PictureBox pb_baixo;
    }
}