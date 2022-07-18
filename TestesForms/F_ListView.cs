using System;
using System.Windows.Forms;

namespace TestesForms
{
    public partial class F_ListView : Form
    {
        ListViewItem Item;
        public F_ListView()
        {
            InitializeComponent();
            
        }
        private void Limpar()
        {
            tb_id.Clear();
            tb_veiculos.Clear();
            tb_quantidade.Clear();
            tb_preco.Clear();
            tb_veiculos.Focus();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (tb_veiculos.Text != "" && tb_quantidade.Text != "" && tb_preco.Text != "") //Verifica se todos os TextBox estão preenchidos
            {
                Item = new ListViewItem();
                Item.SubItems.Add(tb_veiculos.Text);
                Item.SubItems.Add(tb_quantidade.Text);
                Item.SubItems.Add(tb_preco.Text);
                lv_veiculos.Items.Add(Item);
                Limpar();
            }
            else
            {
                MessageBox.Show("Você precisa preencher todos os componentes.", "Error");
                if (tb_veiculos.Text == "")
                {
                    tb_veiculos.Focus();
                }
                else if (tb_quantidade.Text == "")
                {
                    tb_quantidade.Focus();
                }
                else if (tb_preco.Text == "")
                {
                    tb_preco.Focus();
                }
            }
            
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            if(lv_veiculos.SelectedItems.Count != 0)
            {
                lv_veiculos.Items.RemoveAt(lv_veiculos.SelectedIndices[0]);
            }
        }

        private void btn_obter_Click(object sender, EventArgs e)
        {
            if (lv_veiculos.SelectedItems.Count != 0)
            {
                tb_id.Text = lv_veiculos.SelectedItems[0].SubItems[0].Text;
                tb_veiculos.Text = lv_veiculos.SelectedItems[0].SubItems[1].Text;
                tb_quantidade.Text = lv_veiculos.SelectedItems[0].SubItems[2].Text;
                tb_preco.Text = lv_veiculos.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void lv_veiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_veiculos.SelectedItems.Count > 0)
            {
                tb_id.Text = lv_veiculos.SelectedItems[0].SubItems[0].Text;
                tb_veiculos.Text = lv_veiculos.SelectedItems[0].SubItems[1].Text;
                tb_quantidade.Text = lv_veiculos.SelectedItems[0].SubItems[2].Text;
                tb_preco.Text = lv_veiculos.SelectedItems[0].SubItems[3].Text;
            }
        }
    }
}
