using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestesForms
{
    public partial class F_BackgroundWorker : Form
    {
        int maximo = 1000;
        int count = 0;
        bool continuar = true;

        public F_BackgroundWorker()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < maximo; i++)
            {
                count++;
                backgroundWorker1.ReportProgress(0);
                Thread.Sleep(10);
                if(continuar == false)
                {
                    count = 0;
                    break;
                }
            }
            continuar = true;
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
            continuar = true;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            label1.Text = count.ToString();
            progressBar1.Value = count;
        }

        private void btn_resetar_Click(object sender, EventArgs e)
        {
            continuar = false;
            count = 0;
            label1.Text = "0";
            progressBar1.Value = 0;
            backgroundWorker1.CancelAsync();            
        }

        private void btn_parar_Click(object sender, EventArgs e)
        {
            if (continuar == true)
            {
                continuar = false; 
            }
            else
            {
                btn_iniciar_Click(sender, e);
            }
        }
    }
}
