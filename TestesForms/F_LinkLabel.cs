using System;
using System.Windows.Forms;

namespace TestesForms
{
    public partial class F_LinkLabel : Form
    {
        public F_LinkLabel()
        {
            InitializeComponent();

            ll_varioslinks.Links.Add(0, 6, "http://www.google.com");
            ll_varioslinks.Links.Add(9, 7, "http://www.youtube.com");
            ll_varioslinks.Links.Add(19, 8, "http://www.facebook.com");
        }

        private void ll_calculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void ll_varioslinks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            e.Link.Visited = true;
        }

        private void btn_acessar_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(tb_link.Text);
        }
    }
}
