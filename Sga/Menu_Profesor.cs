using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sga
{
    public partial class Menu_Profesor : Form
    {
        public Menu_Profesor()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void AbrirEnPanelCliente(Form formClientes)
        {
            if (this.panel_menuProfesor.Controls.Count > 0)
            {
                this.panel_menuProfesor.Controls.Clear(); 
            }

            if (formClientes != null)
            {
                formClientes.TopLevel = false;
                formClientes.FormBorderStyle = FormBorderStyle.None;
                formClientes.Dock = DockStyle.Fill;
                this.panel_menuProfesor.Controls.Add(formClientes);
                this.panel_menuProfesor.Tag = formClientes;
                formClientes.Show();
            }

        }
        private void btnAggAlumnos_Click(object sender, EventArgs e)
        {
            AbrirEnPanelCliente(new GestionEstudiantes());
        }

        private void btnCerrarMP_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistrarAsisMP_Click(object sender, EventArgs e)
        {
            AbrirEnPanelCliente(new Asistencia());
        }

        private void btnMaxMP_Click(object sender, EventArgs e)
        {
            btnMaxMP.Visible = false;
            btnRestMP.Visible = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnRestMP_Click(object sender, EventArgs e)
        {
            btnRestMP.Visible = false;
            btnMaxMP.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void btnMinMP_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelCabeceraProfe_Paint(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnHorariosMP_Click(object sender, EventArgs e)
        {
            AbrirEnPanelCliente(new frmHorarioProfesor());
        }
    }
}
