using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
   
    public partial class Form1 : Form
    {       

        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Seja Bem Vindo ao Game! \n Teste seu conhecimento em C#!");
            axWindowsMediaPlayer1.uiMode = "none";
        }
                
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja mesmo sair?", "Quiz C#", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) //se apertar SIM na caixa de diálogo
            {
                this.Close();
            }

        }

        private void Quiz_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2Opaco Form2Opaco = new Form2Opaco();
            Form2Opaco.ShowDialog();

            //adicionar o nome e pontuação na lista
            listBox_Nome.Items.Add(VariaveisGlobais.Nome + " " + VariaveisGlobais.Acertos);


        }

        private void Form1_Load(object sender, EventArgs e)
        {


            // Define o caminho do vídeo que você deseja reproduzir
            string caminho = Application.StartupPath;            
            axWindowsMediaPlayer1.URL = caminho + @"\fumacaverde.mp4";
            
            // Habilita o modo de loop
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            // Inicia a reprodução
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listBox_Nome_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

