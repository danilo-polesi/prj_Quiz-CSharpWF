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
    public partial class FormFinal : Form
    {
        public FormFinal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            

        }

        private void FormFinal_Load(object sender, EventArgs e)
        {
            lblAcertos.Text = VariaveisGlobais.Acertos.ToString();
            lblErros.Text = VariaveisGlobais.Erros.ToString();
            lblNome.Text = VariaveisGlobais.Nome.ToString();

            // Define o caminho do vídeo que você deseja reproduzir
            string caminho = Application.StartupPath;
            axWindowsMediaPlayer2.URL = caminho + @"\titanic.mp4";

            // Habilita o modo de loop
            axWindowsMediaPlayer2.settings.setMode("loop", true);
            // Inicia a reprodução
            axWindowsMediaPlayer2.Ctlcontrols.play();

        }
    }
}
