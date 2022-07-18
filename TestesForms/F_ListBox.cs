using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TestesForms
{
    public partial class F_ListBox : Form
    {
        List<string> veiculos = new List<string>();

        public F_ListBox()
        {
            InitializeComponent();
            
            veiculos.Add("Avião");
            veiculos.Add("Carro");
            veiculos.Add("Ônibus");
            veiculos.Add("Trem");

            lb_veiculos.DataSource = veiculos; //Define a fonte de dados do List Box.
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if(tb_digite.Text != "")
            {
                if (lb_veiculos.Items.Contains(tb_digite.Text) == false)
                {
                    veiculos.Add(tb_digite.Text);
                    Atualiza_lbveiculos();
                }
                else
                {
                    MessageBox.Show("Esse veículo já está listado", "Erro");
                }
            }
            tb_digite.Clear();
            tb_digite.Focus();
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            if (lb_veiculos.Items.Count != 0)
            {
                veiculos.RemoveAt(lb_veiculos.SelectedIndex);
                Atualiza_lbveiculos();
            }
        }

        private void btn_obter_Click(object sender, EventArgs e)
        {
            if (lb_veiculos.Items.Count != 0)
            {
                tb_digite.Text = veiculos[lb_veiculos.SelectedIndex];
            }
        }

        private void Atualiza_lbveiculos()
        {
            lb_veiculos.DataSource = null;
            lb_veiculos.DataSource = veiculos;
        }

        private void tb_digite_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_adicionar_Click(sender, e);
            }
        }

        private void btn_resetarlista_Click(object sender, EventArgs e)
        {
            veiculos.Clear();
            veiculos.Add("Avião");
            veiculos.Add("Carro");
            veiculos.Add("Ônibus");
            veiculos.Add("Trem");
            Atualiza_lbveiculos();
        }
    }
}
