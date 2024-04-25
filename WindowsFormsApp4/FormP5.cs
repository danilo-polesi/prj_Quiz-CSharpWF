using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApp4
{
    public partial class FormP5 : Form
    {
        string caminho = Application.StartupPath;
        private SoundPlayer tocador;
        public FormP5()
        {
            InitializeComponent();
        }

        private void btnProxima_Click(object sender, EventArgs e)
        {
            if (rbtn_Correta.Checked == true)
            {
                //MessageBox.Show("Certa resposta!", "Quiz");
                //somar na variavel global os acertos
                VariaveisGlobais.Acertos++;
                //chamar audio do silvio
                tocador = new SoundPlayer(caminho + @"\certaresposta.wav");
                tocador.PlaySync();
                FormP6 P6 = new FormP6();
                P6.ShowDialog();
                this.Dispose();

            }
            else if (radioButton2.Checked || radioButton3.Checked || radioButton4.Checked == true)
            {
                //MessageBox.Show("Esta certo disso?", "Quiz");
                //somar na variavel global os erros
                VariaveisGlobais.Erros++;
                FormP6 P6 = new FormP6();
                P6.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Escolha uma opção!", "Não tem pra onde correr.");
            }
        }

        private void FormP5_Load(object sender, EventArgs e)
        {
            // Define o caminho do vídeo que você deseja reproduzir
            string caminho = Application.StartupPath;
            axWindowsMediaPlayer2.URL = caminho + @"\riscosazuis.mp4";

            // Habilita o modo de loop
            axWindowsMediaPlayer2.settings.setMode("loop", true);
            // Inicia a reprodução
            axWindowsMediaPlayer2.Ctlcontrols.play();
        }

        private void rbtn_Correta_Click(object sender, EventArgs e)
        {
            tocador = new SoundPlayer(caminho + @"\estacertodisso.wav");
            tocador.PlaySync();
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            tocador = new SoundPlayer(caminho + @"\estacertodisso.wav");
            tocador.PlaySync();
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            tocador = new SoundPlayer(caminho + @"\estacertodisso.wav");
            tocador.PlaySync();
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            tocador = new SoundPlayer(caminho + @"\estacertodisso.wav");
            tocador.PlaySync();
        }
    }
}



        
