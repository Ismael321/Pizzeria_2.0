using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria_eddy.Gerente
{
    class SlnGerente
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
        public static void SoloNumeros(KeyPressEventArgs Numero)
        {
            if (char.IsDigit(Numero.KeyChar))
            {
                Numero.Handled = false;
            }
            else if (char.IsSeparator(Numero.KeyChar))
            {
                Numero.Handled = false;
            }
            else if (char.IsControl(Numero.KeyChar))
            {
                Numero.Handled = false;
            }
            else
            {
                Numero.Handled = true;
            }
        }
    }
}
