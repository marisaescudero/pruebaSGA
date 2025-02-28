using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sga
{
    internal class Conexión_BDD
    {
        public SqlConnection oCon;
        public SqlCommand oCom;
        public SqlDataReader oDR;
        public SqlDataAdapter oDA;
        public DataTable oDT;

        private string Server;
        private string Database;
        private string Usuario;
        private string Clave;
        private string Cadena;

        public Conexión_BDD()
        {
            Server = "DESKTOP-9SMDLH8\\SQLEXPRESS";
            Database = "SGA_bdd";
            Usuario = "AccesoChari";
            Clave = "accesochari";
        }

        public Conexión_BDD(string Server, string Database, string Usuario, string Clave)
        {
            this.Server = Server;
            this.Database = Database;
            this.Usuario = Usuario;
            this.Clave = Clave;
        }

        public SqlConnection AbrirConexion()
        {
            try
            {
                oCon = new SqlConnection($"Server={Server}; Database={Database}; User id={Usuario}; Password={Clave}");
                oCon.Open();
                return oCon;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al abrir la conexión: " + ex.Message);
            }
        }

        public bool CerrarConexion()
        {
            if (oCon != null && oCon.State == ConnectionState.Open)
            {
                oCon.Close();
                return true;
            }
            return false;
        }

        public bool eliminarDatos(string Tabla, string Condicion)
        {
            try
            {
                AbrirConexion();
                Cadena = "Delete " + Tabla + " where " + Condicion;
                oCom = new SqlCommand(Cadena, oCon);
                oCom.ExecuteNonQuery();
                CerrarConexion();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool insertarDatos(string Tabla, string Campos, string Datos)
        {
            try
            {
                AbrirConexion();
                Cadena = "Insert into " + Tabla + " (" + Campos + ") values( " + Datos + ")";
                oCom = new SqlCommand(Cadena, oCon);
                oCom.ExecuteNonQuery(); //operacion que no retorna registro
                CerrarConexion();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool actulizarDatos(string Tabla, string Datos, string Condicion)
        {
            try
            {
                AbrirConexion();
                Cadena = "Update " + Tabla + " set " + Datos + " where " + Condicion;
                oCom = new SqlCommand(Cadena, oCon);
                oCom.ExecuteNonQuery();
                CerrarConexion();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool ejecutarSQL(string Sentencia)
        {
            try
            {
                AbrirConexion();  // Asegúrate de que la conexión esté abierta
                oCom = new SqlCommand(Sentencia, oCon);
                oCom.ExecuteNonQuery();  // Ejecutar la sentencia SQL
                CerrarConexion();  // Cerrar la conexión después de la ejecución
                return true;  // Si todo sale bien, retorna true
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al ejecutar la sentencia SQL: {ex.Message}");
                CerrarConexion();  // Asegúrate de cerrar la conexión en caso de error
                return false;  // Si hubo un error, retorna false
            }
        }

        public int retornaValor(string Seleccion, string Tabla, string Condicion)
        {
            int temporal;
            AbrirConexion();
            Cadena = "Select isnull(cast(" + Seleccion + " as int),0) from " + Tabla + " where " + Condicion;
            oCom = new SqlCommand(Cadena, oCon);
            oDR = oCom.ExecuteReader();
            oDR.Read();
            temporal = (int)oDR[0];
            oDR.Close();
            CerrarConexion();
            return temporal;
        }

        public string retornaCadena(string Seleccion, string Tabla, string Condicion)
        {
            string temporal;
            AbrirConexion();
            Cadena = "Select isnull(cast(" + Seleccion + " as varchar(200)),'') from " + Tabla + " where " + Condicion;
            oCom = new SqlCommand(Cadena, oCon);
            oDR = oCom.ExecuteReader();

            if (oDR.Read())
            {
                temporal = (string)oDR[0];
            }
            else
            {
                temporal = "";
            }
            oDR.Close();
            CerrarConexion();
            return temporal;
        }

        public string retornaCadenaConsulta(string Consulta)
        {
            string temporal;
            AbrirConexion();
            oCom = new SqlCommand(Consulta, oCon);
            oDR = oCom.ExecuteReader();
            oDR.Read();
            temporal = (string)oDR[0];
            oDR.Close();
            CerrarConexion();
            return temporal;
        }

        public decimal retornaValorConsulta(string Consulta)
        {
            decimal temporal;
            AbrirConexion();
            oCom = new SqlCommand(Consulta, oCon);
            oDR = oCom.ExecuteReader();
            oDR.Read();
            temporal = (decimal)oDR[0];
            oDR.Close();
            CerrarConexion();
            return temporal;
        }

        public DataTable retornaRegistros(string Sentencia)
        {
            oDT = null;
            if (Sentencia.Length > 0)
            {
                AbrirConexion();
                oCom = new SqlCommand(Sentencia, oCon);
                oDA = new SqlDataAdapter(oCom);
                oDT = new DataTable();
                oDA.Fill(oDT);
                CerrarConexion();
            }
            return oDT;
        }
    }
}
