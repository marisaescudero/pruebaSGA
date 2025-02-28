using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sga
{
    public partial class frmHorarioProfesor : Form
    {
        Conexión_BDD conexion = new Conexión_BDD();
        int profesorID = 1; // Se asignará al iniciar sesión
        int horarioSeleccionadoID = -1; // ID del horario seleccionado
        public frmHorarioProfesor()
        {
            InitializeComponent();
        }

        private void frmHorarioProfesor_Load(object sender, EventArgs e)
        {
            CargarMaterias();
            CargarHorarios();
        }

        private void CargarMaterias()
        {
            string query = "SELECT ID, NombreMateria FROM Materias";
            DataTable dt = conexion.retornaRegistros(query);

            cmbAsignatura.DataSource = dt;
            cmbAsignatura.DisplayMember = "NombreMateria";
            cmbAsignatura.ValueMember = "ID";
        }

        private void CargarHorarios()
        {
            string query = $"SELECT h.ID, h.DiaSemana, h.HoraInicio, h.HoraFin, m.NombreMateria AS Materia " +
                           $"FROM HorariosClases h " +
                           $"JOIN Materias m ON h.MateriaID = m.ID " +
                           $"WHERE h.ProfesorID = {profesorID}";

            DataTable dt = conexion.retornaRegistros(query);
            dgvHorarioProfesor.DataSource = dt;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string dia = cmbDiaSemana.SelectedItem?.ToString();
            string horaInicio = dtpHoraInicio.Value.ToString("HH:mm");
            string horaFin = dtpHoraFin.Value.ToString("HH:mm");
            int materiaID = Convert.ToInt32(cmbAsignatura.SelectedValue);

            if (string.IsNullOrWhiteSpace(dia))
            {
                MessageBox.Show("Seleccione un día de la semana.");
                return;
            }

            string query = $"INSERT INTO HorariosClases (ProfesorID, DiaSemana, HoraInicio, HoraFin, MateriaID) " +
                           $"VALUES ({profesorID}, '{dia}', '{horaInicio}', '{horaFin}', {materiaID})";

            if (conexion.ejecutarSQL(query))
            {
                MessageBox.Show("Horario agregado correctamente.");
                CargarHorarios();
            }
            else
            {
                MessageBox.Show("Error al agregar el horario.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (horarioSeleccionadoID == -1)
            {
                MessageBox.Show("Seleccione un horario para editar.");
                return;
            }

            string dia = cmbDiaSemana.SelectedItem?.ToString();
            string horaInicio = dtpHoraInicio.Value.ToString("HH:mm");
            string horaFin = dtpHoraFin.Value.ToString("HH:mm");
            int materiaID = Convert.ToInt32(cmbAsignatura.SelectedValue);

            string query = $"UPDATE HorariosClases SET DiaSemana = '{dia}', HoraInicio = '{horaInicio}', " +
                           $"HoraFin = '{horaFin}', MateriaID = {materiaID} WHERE ID = {horarioSeleccionadoID}";

            if (conexion.ejecutarSQL(query))
            {
                MessageBox.Show("Horario actualizado correctamente.");
                CargarHorarios();
            }
            else
            {
                MessageBox.Show("Error al actualizar el horario.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (horarioSeleccionadoID == -1)
            {
                MessageBox.Show("Seleccione un horario para eliminar.");
                return;
            }

            DialogResult result = MessageBox.Show("¿Está seguro de eliminar este horario?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string query = $"DELETE FROM HorariosClases WHERE ID = {horarioSeleccionadoID}";

                if (conexion.ejecutarSQL(query))
                {
                    MessageBox.Show("Horario eliminado correctamente.");
                    CargarHorarios();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el horario.");
                }
            }

        }

        private void dgvHorarioProfesor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHorarioProfesor.Rows[e.RowIndex];
                horarioSeleccionadoID = Convert.ToInt32(row.Cells["ID"].Value);
                cmbDiaSemana.SelectedItem = row.Cells["DiaSemana"].Value.ToString();
                dtpHoraInicio.Value = DateTime.Parse(row.Cells["HoraInicio"].Value.ToString());
                dtpHoraFin.Value = DateTime.Parse(row.Cells["HoraFin"].Value.ToString());
                cmbAsignatura.Text = row.Cells["Materia"].Value.ToString();
            }
        }
    }
}
