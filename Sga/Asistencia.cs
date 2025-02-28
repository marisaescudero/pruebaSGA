using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sga
{
    public partial class Asistencia : Form
    {
        public Asistencia()
        {
            InitializeComponent();
        }

       

        private void btnLista_Click(object sender, EventArgs e)
        {
            
           
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu formAnterior = new Menu();
            formAnterior.Show();
        }

        private void pcCerrarAsistencia_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcMinimizarAsistencia_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
