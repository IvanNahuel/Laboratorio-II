using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personas
{
    public partial class formulariosPersona : Form
    {
        public Personas persona;
        public Form1 form1;
        bool auxPer;

        public formulariosPersona()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            form1 = new Form1();

            persona = new Personas();
            persona.Nombre = this.txtNombre.Text;
            persona.Apellido = this.txtApellido.Text;
            persona.Dni = this.txtDni.Text;

            auxPer = form1.personas + persona;

            form1.Show();
            //this.DialogResult = DialogResult.OK;
        }
    }
}
