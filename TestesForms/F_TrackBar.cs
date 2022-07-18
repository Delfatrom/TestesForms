using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestesForms
{
    public partial class F_TrackBar : Form
    {
        public F_TrackBar()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            tb_valor.Text = trackBar1.Value.ToString();
            label1.Text = trackBar1.Value.ToString();
        }

        private void btn_definir_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(tb_valor.Text) <= trackBar1.Maximum && Int32.Parse(tb_valor.Text) >= trackBar1.Minimum)
            {
                trackBar1.Value = Convert.ToInt32(tb_valor.Text);
                label1.Text = tb_valor.Text;
                tb_valor.Focus();
            }
            else
            {
                MessageBox.Show("O valor deve estar entre o máximo e o mínimo do TrackBar (0 - 10)", "Error");
                tb_valor.Focus();
            }
        }

        private void tb_valor_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_definir_Click(sender, e);
            }
        }
    }
}
