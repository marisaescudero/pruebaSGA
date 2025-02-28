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
    public partial class frmHorarioAlumno : Form
    {
        private Conexión_BDD conexion = new Conexión_BDD();
        private int alumnoID = 1; // CAMBIAR por el ID del alumno logueado
        public frmHorarioAlumno()
        {
            InitializeComponent();
        }

        private void frmHorarioAlumno_Load(object sender, EventArgs e)
        {
            CargarHorarioAlumno();
        }

        private void CargarHorarioAlumno()
        {
            string query = "SELECT h.DiaSemana, h.HoraInicio, h.HoraFin, m.NombreMateria AS Materia, " +
                           "p.NombreCompleto AS Profesor " +
                           "FROM HorariosClases h " +
                           "JOIN Materias m ON h.MateriaID = m.ID " +
                           "JOIN Profesores p ON h.ProfesorID = p.ID " +
                           "ORDER BY h.DiaSemana, h.HoraInicio";

            DataTable dt = conexion.retornaRegistros(query);
            dgvHorarioAlumno.DataSource = dt;
        }
    }
}
