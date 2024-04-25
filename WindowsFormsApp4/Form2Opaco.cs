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
    public partial class Form2Opaco : Form
    {
        private Form2Opaco form2;

        public Form2Opaco()
        {
            InitializeComponent();
        }

        private void Form2Opaco_Load(object sender, EventArgs e)
        {
            

            frm_Nome P1 = new frm_Nome();
            P1.ShowDialog();

            if (form2 != null && !form2.IsDisposed)
            {
                // Fecha Form2
                form2.Close();
            }

            // Fecha também o frm_Nome
            this.Close();



        }
    }
}
