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
    public partial class F_TreeView : Form
    {
        public F_TreeView()
        {
            InitializeComponent();            
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            TreeNode NovaRaiz = new TreeNode();
            NovaRaiz.Text = tb_veiculos.Text;
            treeView1.Nodes.Add(NovaRaiz);                        
        }

        private void btn_adicionarFilho_Click(object sender, EventArgs e)
        {
            TreeNode NovoFilho = new TreeNode();
            NovoFilho.Text = tb_veiculos.Text;
            treeView1.SelectedNode.Nodes.Add(NovoFilho);
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            try
            {
                if(treeView1.Nodes.Count >= 1)
                {
                    treeView1.SelectedNode.Remove();
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover nó.", "Error em btn_remover_Click");
            }
        }
    }
}
