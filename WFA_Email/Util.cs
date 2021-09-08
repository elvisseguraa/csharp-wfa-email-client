using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Email
{
    class Util
    {
        public static string MsgBox(string titulo, string mensaje)
        {
            FormInput frm = new FormInput();
            frm.Titulo = titulo;
            frm.Mensaje = mensaje;
            frm.ShowDialog();
            return frm.Valor;
        }
    }
}
