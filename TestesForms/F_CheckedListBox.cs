using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TestesForms
{
    public partial class F_CheckedListBox : Form
    {
        public F_CheckedListBox()
        {
            InitializeComponent();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (clb_veiculos.Items.Contains(tb_veiculo.Text))
            {
                MessageBox.Show("Esse veículo já está listado","Veículo listado");
            }
            else if(tb_veiculo.Text != "")
            {
                clb_veiculos.Items.Add(tb_veiculo.Text);
            }
            clb_veiculos.EndUpdate();
            tb_veiculo.Clear();
            tb_veiculo.Focus();
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            List<string> veiculos = new List<string>();
            if (clb_veiculos.Items.Contains(tb_veiculo.Text))
            {
                clb_veiculos.Items.Remove(tb_veiculo.Text);
            }
            tb_veiculo.Focus();
            tb_veiculo.Clear();
        }

        private void tb_veiculo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_adicionar_Click(sender, e);
            }
        }

        private void btn_mostrarselecionados_Click(object sender, EventArgs e)
        {
            string selecionados = "";
            foreach (string s in clb_veiculos.CheckedItems)
            {
                selecionados += s + ", ";
            }
            if(selecionados.Length > 0)
            {
                selecionados = selecionados.Remove(selecionados.Length - 2);
                MessageBox.Show(selecionados + ".", "Selecionados: ");
            }
            else
            {
                MessageBox.Show("Nenhum selecionado.", "Selecionados: ");
            }
        }

        private void btn_resetarlista_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clb_veiculos.Items.Count; i++)
            {
                clb_veiculos.SetItemCheckState(i, 0);
            }
        }

        private void btn_resetarlista_Click_1(object sender, EventArgs e)
        {
            clb_veiculos.Items.Clear();
            clb_veiculos.Items.Add("Avião");
            clb_veiculos.Items.Add("Carro");
            clb_veiculos.Items.Add("Ônibus");
        }
    }
}
