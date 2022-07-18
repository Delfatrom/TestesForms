using System;
using System.Windows.Forms;

namespace TestesForms
{
    public partial class F_PictureBox : Form
    {
        public F_PictureBox()
        {
            InitializeComponent();
        }

        private void btn_mudar_Click(object sender, EventArgs e)
        {
            if(pb_cima.Image != null)
            {
                pb_cima.Image = null;
                pb_baixo.Image = Properties.Resources.img_capturar;
                btn_mudar.Text = "Mudar para cima";
            }
            else
            {
                btn_mudar.Text = "Mudar para baixo";                
                pb_baixo.Image = null;
                pb_cima.Image = Properties.Resources.img_capturar;
            }
        }
    }
}
