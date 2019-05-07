using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria_eddy.Ordenar
{
    class slnOrdenar
    {
        public static void SoloLetras(KeyPressEventArgs Letra)
        {
            if (char.IsLetter(Letra.KeyChar))
            {
                Letra.Handled = false;
            }
            else if (char.IsSeparator(Letra.KeyChar))
            {
                Letra.Handled = false;
            }
            else if (char.IsControl(Letra.KeyChar))
            {
                Letra.Handled = false;
            }
            else
            {
                Letra.Handled = true;
            }
        }
        public static void RegistroFacturas(string NombreCompleto, int TotalFinal)
        {
            Conexion.Conexion ObjetoConexion = new Conexion.Conexion();
            ObjetoConexion.Abrir_coneccion();
            String Query = "insert into Factura (Nombre, CostoTotal) values ('" + NombreCompleto + "'," + TotalFinal + ")";
            ObjetoConexion.EjecutarSqlGerente(Query);
            ObjetoConexion.Cerrar_Coneccion();
        }
        public static void RegsitroFacturaDom(String NombreCompleto, String DomD,String NumeroD, String CalleD, String CalleD2, String Comen, int TotalD)
        {
            Conexion.Conexion ObjetoConexion = new Conexion.Conexion();
            ObjetoConexion.Abrir_coneccion();
            String Query = "insert into Factura (Nombre, Domicilio, Num_Dom, Calle1, Calle2, Comentarios, CostoTotal) values ('" + NombreCompleto + "','" + DomD + "','" + NumeroD + "','" + CalleD + "','" + CalleD2 + "','" + Comen + "'," + TotalD + ")";
            ObjetoConexion.EjecutarSqlGerente(Query);
            ObjetoConexion.Cerrar_Coneccion();
        }
    }
}
