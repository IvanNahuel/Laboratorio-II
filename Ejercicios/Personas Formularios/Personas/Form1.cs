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
    public partial class Form1 : Form
    {
        public List<Personas> personas;

        //hacer una lista de personas, añadir mediante formularios, personas a la lista de personas y mostrarlosmediante 
        //el listBox

        public Form1()
        {
            InitializeComponent();
            this.personas = new List<Personas>();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            formulariosPersona formulariosPersona = new formulariosPersona();

            formulariosPersona.Show();
            /*
            if (formulariosPersona.ShowDialog()== DialogResult.OK)
            {
                this.personas.Add(formulariosPersona.persona);

                
            }*/
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            foreach (Personas p in personas)
            {
                this.lstTexto.Items.Add(p.Nombre + " " + p.Apellido + " " + p.Dni);
            }
        }
    }
}
