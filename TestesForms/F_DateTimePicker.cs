using System;
using System.Windows.Forms;

namespace TestesForms
{
    public partial class F_DateTimePicker : Form
    {
        public F_DateTimePicker()
        {
            InitializeComponent();
        }

        private void btn_ObterData_Click(object sender, EventArgs e)
        {
            tb_data.Clear();
            dtp_data_ValueChanged(sender, e);
            tb_data.Text = dtp_data.Text;
        }

        private void dtp_data_ValueChanged(object sender, EventArgs e)
        {
            tb_dia.Text = dtp_data.Value.Day.ToString();
            tb_mes.Text = dtp_data.Value.Month.ToString();
            tb_ano.Text = dtp_data.Value.Year.ToString();
        }

        private void btn_setardata_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dt = new DateTime(Int32.Parse(tb_ano.Text), Int32.Parse(tb_mes.Text), Int32.Parse(tb_dia.Text));
                dtp_data.Value = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Formato de data incorreto.\nO dia precisa estar entre 1 e 31.\nO mês precisa estar entre 1 e 12.\n\nLocal do erro: btn_setardata_Click", "Erro");
                if(Int32.Parse(tb_dia.Text) < 1 || Int32.Parse(tb_dia.Text) > 31)
                {
                    tb_dia.Clear();
                    tb_dia.Focus();
                }
                if (Int32.Parse(tb_mes.Text) < 1 || Int32.Parse(tb_mes.Text) > 12)
                {
                    tb_mes.Clear();
                    tb_mes.Focus();
                }
            }
        }

        private void btn_hoje_Click(object sender, EventArgs e)
        {
            dtp_data.Value = DateTime.Today;
        }
    }
}
