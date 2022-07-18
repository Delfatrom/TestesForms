using System;
using System.Windows.Forms;

namespace TestesForms
{
    public partial class F_ComboBox : Form
    {
        public F_ComboBox()
        {
            InitializeComponent();
        }

        private void btn_MostrarSelecionados_Click(object sender, EventArgs e)
        {
            if (cb_veiculos.SelectedItem != null)
            {
                MessageBox.Show(cb_veiculos.SelectedItem.ToString() + '.', "Item selecionado:");
                tb_veiculos.Text = cb_veiculos.Text;
            }
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            cb_veiculos.SelectedItem = null;
            cb_veiculos.Items.Clear();
        }

        private void btn_ResetarElementos_Click(object sender, EventArgs e)
        {
            cb_veiculos.Items.Clear();
            if (cb_veiculos.Items.Count == 0)
            {
                cb_veiculos.Items.Add("Avião");
                cb_veiculos.Items.Add("Carro");
                cb_veiculos.Items.Add("Ônibus");
                cb_veiculos.Items.Add("Trem");
            }
        }

        private void cb_veiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_veiculos.Text = cb_veiculos.Text;
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            if(tb_veiculos.Text != "")
            {
                if (cb_veiculos.FindString(tb_veiculos.Text) < 0) //FindString retorna "-1" caso a string não exista
                {
                    cb_veiculos.Items.Add(tb_veiculos.Text);
                    tb_veiculos.Clear();
                    tb_veiculos.Focus();
                }
            }
            else
            {
                MessageBox.Show("Você precisa digitar um veículo.", "Error");
                tb_veiculos.Focus();
            }
        }

        private void tb_veiculos_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_Adicionar_Click(sender, e);
            }
        }
    }
}
