using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace DesktopApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEVIDENCIA_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.nsu = txtNSU.Text;
            VariaveisGlobais.fullnsu = txtFULL_NSU.Text;

            //VariaveisGlobais.breakLine = txtBREAK_LINE.Text;
            VariaveisGlobais.breakLine = cmbBreakLine.SelectedItem.ToString();

            VariaveisGlobais.dataLog = txtDATA_LOG.Text;
            VariaveisGlobais.is400 = check400.Checked;

            if (txtLOG_PATH != null)
                VariaveisGlobais.logPath = txtLOG_PATH.Text;

            if (txtEVIDENCIA_PATH != null)
                VariaveisGlobais.evidenciaPath = txtEVIDENCIA_PATH.Text;

            EvidenciaHandler eh = new EvidenciaHandler();
            bool gerou = eh.ReadDirectory();
            string message = "";
            if (gerou)
            {
                message = "Arquivo de evidência gerado!!";
            }
            else
            {
                message = "Arquivo não gerado";
            }
            MessageBox.Show(message);
        }

        private void btnVALIDAR_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.nsu = txtNSU.Text;
            VariaveisGlobais.fullnsu = txtFULL_NSU.Text;

            //VariaveisGlobais.breakLine = txtBREAK_LINE.Text;
            VariaveisGlobais.breakLine = cmbBreakLine.SelectedItem.ToString();

            VariaveisGlobais.versaoMensageria = cmbVERSION.SelectedItem.ToString();

            ValidarHandler vh = new ValidarHandler();
            if (vh.getFile())
            {
                vh.validar();
            }
            else
            {
                MessageBox.Show("Arquivo não de evidência não encontrado");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //check se existe diretorios se nao cria
            //diretorio EVIDENCIAS
            string path = FuncoesGlobais.retornaRoot();
            FuncoesGlobais.checkDirectory(path,"EVIDENCIAS");
            //diretorio LOGS
            FuncoesGlobais.checkDirectory(path, "LOGS");

            //seleciona o primeiro item como default
            cmbVERSION.SelectedIndex = 0;

            //adiciona itens ao Break Line drop down
            cmbBreakLine.Items.Add("*** ACTR ***");
            cmbBreakLine.Items.Add("MENSAGEM=>");
            cmbBreakLine.Items.Add("======================================================================================================================================================");
            cmbBreakLine.SelectedIndex = 0;

            //DateTime.UtcNow baseado no fuso horario
            string date = DateTime.Now.ToString("yy-MM-dd");
            txtDATA_LOG.Text = date;
        }
    }
}
