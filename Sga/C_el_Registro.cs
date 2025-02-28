using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sga
{
    internal class C_el_Registro
    {
        private Conexión_BDD conexion = new Conexión_BDD();

        public bool RegistrarAlumno(string gmail, string contraseña, string nombreCompleto, string cedula, string nombrePadre, string nombreMadre, string telefono)
        {
            using (SqlConnection con = conexion.AbrirConexion())
            {
                SqlTransaction transaction = con.BeginTransaction();
                try
                {
                    // Insertar en la tabla Usuarios primero
                    string queryUsuarios = "INSERT INTO Usuarios (Gmail, Contraseña, TipoUsuario) OUTPUT INSERTED.ID VALUES (@Gmail, @Contraseña, 'Alumno')";
                    SqlCommand cmdUsuarios = new SqlCommand(queryUsuarios, con, transaction);
                    cmdUsuarios.Parameters.AddWithValue("@Gmail", gmail);
                    cmdUsuarios.Parameters.AddWithValue("@Contraseña", contraseña);
                    int usuarioID = (int)cmdUsuarios.ExecuteScalar();

                    // Insertar en la tabla Alumnos
                    string queryAlumnos = "INSERT INTO Alumnos (UsuarioID, NombreCompleto, Cedula, NombrePadre, NombreMadre, Telefono, Gmail) " +
                                          "VALUES (@UsuarioID, @NombreCompleto, @Cedula, @NombrePadre, @NombreMadre, @Telefono, @Gmail)";
                    SqlCommand cmdAlumnos = new SqlCommand(queryAlumnos, con, transaction);
                    cmdAlumnos.Parameters.AddWithValue("@UsuarioID", usuarioID);
                    cmdAlumnos.Parameters.AddWithValue("@NombreCompleto", nombreCompleto);
                    cmdAlumnos.Parameters.AddWithValue("@Cedula", cedula);
                    cmdAlumnos.Parameters.AddWithValue("@NombrePadre", nombrePadre);
                    cmdAlumnos.Parameters.AddWithValue("@NombreMadre", nombreMadre);
                    cmdAlumnos.Parameters.AddWithValue("@Telefono", telefono);
                    cmdAlumnos.Parameters.AddWithValue("@Gmail", gmail);

                    cmdAlumnos.ExecuteNonQuery();
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error al registrar alumno: " + ex.Message);
                    return false;
                }
            }
        }

        public bool RegistrarProfesor(string nombres, string apellidos, string cedula, string telefono, string gmail, string contraseña)
        {
            using (SqlConnection con = conexion.AbrirConexion())
            {
                SqlTransaction transaction = con.BeginTransaction();
                try
                {
                    string queryUsuarios = "INSERT INTO Usuarios (Gmail, Contraseña, TipoUsuario) OUTPUT INSERTED.ID VALUES (@Gmail, @Contraseña, 'Profesor')";
                    SqlCommand cmdUsuarios = new SqlCommand(queryUsuarios, con, transaction);
                    cmdUsuarios.Parameters.AddWithValue("@Gmail", gmail);
                    cmdUsuarios.Parameters.AddWithValue("@Contraseña", contraseña);
                    int usuarioID = (int)cmdUsuarios.ExecuteScalar();

                    string queryProfesores = "INSERT INTO Profesores (UsuarioID, Nombres, Apellidos, Cedula, Telefono, Gmail) VALUES (@UsuarioID, @Nombres, @Apellidos, @Cedula, @Telefono, @Gmail)";
                    SqlCommand cmdProfesores = new SqlCommand(queryProfesores, con, transaction);
                    cmdProfesores.Parameters.AddWithValue("@UsuarioID", usuarioID);
                    cmdProfesores.Parameters.AddWithValue("@Nombres", nombres);
                    cmdProfesores.Parameters.AddWithValue("@Apellidos", apellidos);
                    cmdProfesores.Parameters.AddWithValue("@Cedula", cedula);
                    cmdProfesores.Parameters.AddWithValue("@Telefono", telefono);
                    cmdProfesores.Parameters.AddWithValue("@Gmail", gmail);

                    cmdProfesores.ExecuteNonQuery();
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error al registrar profesor: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
