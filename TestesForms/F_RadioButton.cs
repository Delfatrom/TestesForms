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
    public partial class F_RadioButton : Form
    {
        public F_RadioButton()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (groupBox1.Controls.OfType<RadioButton>().Any(RadioButton => RadioButton.Checked)) //Verifica se dentro do groupbox1 possui algum radiobutton marcado
            {
                string txt = groupBox1.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
                textBox1.Text = txt;
            }            
        }
    }
}
