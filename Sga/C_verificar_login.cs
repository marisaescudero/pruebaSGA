using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sga
{
    internal class C_verificar_login
    {
        private string cadenaConexion = "Server=DESKTOP-9SMDLH8\\SQLEXPRESS;Database=SGA_bdd;User Id=AccesoChari;Password=accesochari;";

        public bool VerificarLogin(string gmail, string contraseña)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT COUNT(*) FROM Usuarios WHERE Gmail = @Gmail AND Contraseña = @Contraseña";
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Gmail", gmail);
                        cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                        int cuentaUsuarios = (int)cmd.ExecuteScalar();
                        return cuentaUsuarios > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al verificar el login: " + ex.Message);
                    return false;
                }
            }
        }

        public string ObtenerTipoUsuario(string gmail)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT TipoUsuario FROM Usuarios WHERE Gmail = @Gmail";
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Gmail", gmail);
                        return cmd.ExecuteScalar()?.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el tipo de usuario: " + ex.Message);
                    return null;
                }
            }
        }
    }
}
