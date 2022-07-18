using System;
using System.Windows.Forms;

namespace TestesForms
{
    public partial class F_TabControl : Form
    {
        public F_TabControl()
        {
            InitializeComponent();
            numericUpDown1.Maximum = tabControl1.TabPages.Count;
        }       

        private void btn_novaAba_Click(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = tabControl1.TabPages.Count;
            if (tb_abas.Text != "")
            {
                TabPage novaAba = new TabPage();
                novaAba.Name = tb_abas.Text;
                novaAba.Text = tb_abas.Text;
                novaAba.TabIndex = tabControl1.TabPages.Count;
                tabControl1.TabPages.Add(novaAba);
                tb_abas.Clear();
                tb_abas.Focus();
            }
        }

        private void btn_removerAba_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            numericUpDown1.Maximum = tabControl1.TabPages.Count;
        }

        private void btn_acessarAba_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = Convert.ToInt32(numericUpDown1.Value.ToString());
        }
    }
}
