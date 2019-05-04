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
    }
}
