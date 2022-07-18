using System;
using System.Windows.Forms;

namespace TestesForms
{
    public partial class F_ProgressBar : Form
    {
        public F_ProgressBar()
        {
            InitializeComponent();
        }

        private void btn_preenchervalor_Click(object sender, EventArgs e)
        {
            if(int.Parse(tb_valor.Text) <= progressBar1.Maximum && int.Parse(tb_valor.Text) >= progressBar1.Minimum)
            {
                progressBar1.Value = int.Parse(tb_valor.Text);
            }            
        }
    }
}
