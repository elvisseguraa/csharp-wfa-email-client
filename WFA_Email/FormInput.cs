using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Email
{
    public partial class FormInput : Form
    {
        public string Valor { get; set; }
        public string Mensaje { get; set; }
        public string Titulo { get; set; }

        public FormInput()
        {
            InitializeComponent();
        }

        private void FormInput_Load(object sender, EventArgs e)
        {
            this.Text = Titulo;
            this.lblCustom.Text = Mensaje;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Valor = txtValue.Text;
            this.Hide();
        }
    }
}
