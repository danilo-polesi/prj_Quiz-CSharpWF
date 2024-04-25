using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    
    public partial class frm_Nome : Form
    {
        

        public frm_Nome()
        {
            InitializeComponent();
           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

              

        private void frm_Nome_Load(object sender, EventArgs e)
        {
            CancelButton = btnSair; //se precionar o ESC
            AcceptButton = button1;//quando der ENTER

            // Define o caminho do vídeo que você deseja reproduzir
            string caminho = Application.StartupPath;
            axWindowsMediaPlayer2.URL = caminho + @"\vrd.mp4";

            // Habilita o modo de loop
            axWindowsMediaPlayer2.settings.setMode("loop", true);
            // Inicia a reprodução
            axWindowsMediaPlayer2.Ctlcontrols.play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Digite seu nomejogador!", "Quiz");
                txtNome.Focus();

            } else
            {
                VariaveisGlobais.Acertos = 0;
                VariaveisGlobais.Erros = 0;
                VariaveisGlobais.Nome = (txtNome.Text);

                FormP1 P1 = new FormP1();
                P1.ShowDialog();
                this.Close();
            }
            

            //JogadorGlobal.Nome = "Jogador1";
            //JogadorGlobal.Pontos = 100;

            
            
        }
    }
}
