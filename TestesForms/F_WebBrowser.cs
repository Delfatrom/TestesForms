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
    public partial class F_WebBrowser : Form
    {
        public F_WebBrowser()
        {
            InitializeComponent();            
        }

        private void F_WebBrowser_SizeChanged(object sender, EventArgs e)
        {
            webBrowser1.Size = new Size(this.Width, this.Height - 40); //Defini o tamanho da ferramenta WebBrowser para ocupar toda a tela
        }

        private void btn_ir_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(tb_url.Text);
        }

        private void tb_url_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_ir_Click(sender, e);
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
            btn_voltar.Enabled = webBrowser1.CanGoBack;
        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
            btn_proximo.Enabled = webBrowser1.CanGoForward;
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }
    }
}
