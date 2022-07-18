using System;
using System.Windows.Forms;

namespace TestesForms
{
    public partial class Form1 : Form
    {
        //Declarando formulários
        F_CheckedListBox f_CheckedListBox = new F_CheckedListBox();
        F_ComboBox f_ComboBox = new F_ComboBox();
        F_DateTimePicker f_DateTimePicker = new F_DateTimePicker();
        F_LinkLabel f_LinkLabel = new F_LinkLabel();
        F_ListBox f_ListBox = new F_ListBox();
        F_ListView f_ListView = new F_ListView();
        F_NumericUpDown f_NumericUpDown = new F_NumericUpDown();
        F_PictureBox f_PictureBox = new F_PictureBox();
        F_ProgressBar f_ProgressBar = new F_ProgressBar();
        F_RadioButton f_RadioButton = new F_RadioButton();
        F_TrackBar f_TrackBar = new F_TrackBar();
        F_TreeView f_TreeView = new F_TreeView();
        F_WebBrowser f_WebBrowser = new F_WebBrowser();
        F_TabControl f_TabControl = new F_TabControl();
        F_BackgroundWorker f_BackgroundWorker = new F_BackgroundWorker();

        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_CheckedListBox.ShowDialog();
        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_ComboBox.ShowDialog();
        }

        private void dateTimePickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_DateTimePicker.ShowDialog();
        }

        private void labelLinkLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_LinkLabel.ShowDialog();
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_ListBox.ShowDialog();
        }

        private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_ListView.ShowDialog();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if(tb_senha.Text == "123")
            {
                menu_principal.Visible = true;
            }            
        }

        private void cb_mostrarsenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_mostrarsenha.Checked)
            {
                tb_senha.PasswordChar = '\0';
            }
            else
            {
                tb_senha.PasswordChar = '*';
            }
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem.Name.ToString() == "tsmi_abrir")
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (e.ClickedItem.Name.ToString() == "tsmi_fechar")
            {
                this.Close();
            }
        }

        private void numericUpDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_NumericUpDown.ShowDialog();
        }

        private void pictureBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_PictureBox.ShowDialog();
        }

        private void progressBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_ProgressBar.ShowDialog();
        }

        private void radioButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_RadioButton.ShowDialog();
        }

        private void trackBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_TrackBar.ShowDialog();
        }

        private void treeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_TreeView.ShowDialog();
        }

        private void webBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_WebBrowser.ShowDialog();
        }

        private void tabControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_TabControl.ShowDialog();
        }

        private void backgroundWorkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_BackgroundWorker.ShowDialog();
        }
    }
}
