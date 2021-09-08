using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Email.Entity
{
    class MailFormatCustom : IDisposable
    {
        public string emisor { get; set; }
        public string clave { get; set; }
        public ListBox destinatarios { get; set; }
        public string asunto { get; set; }
        public TextBox cuerpo { get; set; }

        public MailFormatCustom()
        {

        }


        private bool disposedValue;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: eliminar el estado administrado (objetos administrados)
                }

                // TODO: liberar los recursos no administrados (objetos no administrados) y reemplazar el finalizador
                // TODO: establecer los campos grandes como NULL
                disposedValue = true;
            }
        }

        // // TODO: reemplazar el finalizador solo si "Dispose(bool disposing)" tiene código para liberar los recursos no administrados
        // ~MailFormat()
        // {
        //     // No cambie este código. Coloque el código de limpieza en el método "Dispose(bool disposing)".
        //     Dispose(disposing: false);
        // }

        void IDisposable.Dispose()
        {
            // No cambie este código. Coloque el código de limpieza en el método "Dispose(bool disposing)".
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
