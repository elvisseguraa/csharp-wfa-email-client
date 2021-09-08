using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_Email.Entity;

namespace WFA_Email
{
    public partial class Form1 : Form
    {

        List<string> listaCorreos = new List<string>();

        public Form1()
        {
            InitializeComponent();
            // 
            LoadCboProviders();
        }

        private void LoadCboProviders()
        {
            string[] providers = new string[] { "Gmail", "Outlook" };
            cboProviders.DataSource = providers;
            cboProviders.SelectedIndex = -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }



        void SendMail(MailFormatCustom fc)
        {
            List<String> lista = new List<String>();
            String mensaje = "";

            MailMessage oMensaje = new MailMessage();
            oMensaje.From = new MailAddress(fc.emisor, "C#");

            foreach (var item in fc.destinatarios.Items)
            {
                oMensaje.To.Add(new MailAddress(item.ToString()));
            }

            oMensaje.Subject = fc.asunto;
            foreach (var item in fc.cuerpo.Text)
            {
                mensaje = mensaje + item;
            }
            oMensaje.Body = mensaje;
            oMensaje.IsBodyHtml = false; // para enviar solo mensaje de texto sin formato

            //Configurar la cuenta para el envio de correo
            SmtpClient cuenta = new SmtpClient();
            NetworkCredential credenciales = new NetworkCredential();
            credenciales.UserName = fc.emisor;
            credenciales.Password = fc.clave;
            cuenta.Credentials = credenciales;
            //Enviar el correo
            try
            {
                if (cboProviders.SelectedIndex == 0) // google
                {
                    cuenta.Host = "smtp.gmail.com";
                    cuenta.Port = 587;
                    cuenta.EnableSsl = true;
                } else if (cboProviders.SelectedIndex == 1) // outlook
                {
                    cuenta.Host = "smtp.live.com";
                    cuenta.Port = 25;
                    cuenta.EnableSsl = true;
                }
                    
                cuenta.Send(oMensaje);
                MessageBox.Show("Correo enviado.");
            }
            catch (Exception ex)
            {
                WriteLogErrors(ex.Message);
            }

        }
        void WriteLogErrors(string error)
        {
            System.IO.StreamWriter flujo = new System.IO.StreamWriter(@"D:\Data\Log\errores.txt", true);
            flujo.Write(error + "\r\n");
            flujo.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            MailFormatCustom fc = new MailFormatCustom();
            fc.emisor = txtEmail.Text;
            fc.clave = txtPassword.Text;
            fc.asunto = txtSubject.Text;
            fc.destinatarios = lstboxEmails;
            fc.cuerpo = txtBody;
            bool ok = ValidateData();
            if (ok)
            {
                try
                {
                    SendMail(fc);                    
                    // this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                
                
            }
            
        }


        private bool ValidateData()
        {

            if (txtEmail.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Ingrese las credenciales de emisor");
                return false;
            }
            else if (txtSubject.Text == "")
            {
                MessageBox.Show("Ingrese el asunto");
                return false;
            }
            else if (lstboxEmails.Items.Count == 0)
            {
                MessageBox.Show("Ingrese destinatario(s)");
                return false;
            }

                return true;

        }

        private void btnAddRecipient_Click(object sender, EventArgs e)
        {
            string sEmail = Util.MsgBox("Agregar destinatario", "Ingrese un nuevo correo");
            if (sEmail != "")
            {
                lstboxEmails.DataSource = null;
                lstboxEmails.Items.Clear();
                
                listaCorreos.Add(sEmail);
                lstboxEmails.DataSource = listaCorreos;
            }
            
        }
    }
}
