using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Pizzaria_eddy.Conexion
{
    class Conexion
    {
        public static bool Is_Ok = false;

        static string CadenaConexion = "Data Source=DESKTOP-0296OVT;Initial Catalog=Pizza;Integrated Security=True";

        SqlConnection ConexionDB = new SqlConnection(CadenaConexion);

        public void Abrir_coneccion()
        {
            if (ConexionDB.State == System.Data.ConnectionState.Closed)
            { ConexionDB.Open(); }
        }
        public void Cerrar_Coneccion()
        {
            if (ConexionDB.State == System.Data.ConnectionState.Open)
            { ConexionDB.Close(); }
        }
        public void ActualizarGrid(DataGridView dgGrid, String Query, String Tabla)
        {
            this.Abrir_coneccion();
            System.Data.DataSet Dataset = new System.Data.DataSet();
            SqlDataAdapter DtAdapter = new SqlDataAdapter(Query, ConexionDB);
            DtAdapter.Fill(Dataset, Tabla);
            dgGrid.DataSource = Dataset;
            dgGrid.DataMember = Tabla;
            this.Cerrar_Coneccion();
        }
        public void EjecutarSql(String Query)
        {
            SqlCommand Micomando = new SqlCommand(Query, ConexionDB);
            int FilasAfectadas = Micomando.ExecuteNonQuery();
            if (FilasAfectadas > 0)
                MessageBox.Show("Operacion Realizada con exito", "La base de Datos a sido Modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo realizar la Modificacion de la Base de Datos", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void EjecutarSqlGerente(String Query2)
        {
            SqlCommand Micomando = new SqlCommand(Query2, ConexionDB);
            int FilasAfectadas = Micomando.ExecuteNonQuery();
            Is_Ok = false;
            if (FilasAfectadas > 0)
            {
                Is_Ok = true;
            }
            else if (FilasAfectadas <= 0)
            {
                Is_Ok = false;
            }
        }
    }
}
