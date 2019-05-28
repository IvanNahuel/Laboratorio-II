using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;


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
    }

    private void btnRefrescar_Click(object sender, EventArgs e)
    {
      foreach (Personas p in personas)
      {
        this.lstTexto.Items.Add(p.Nombre + " " + p.Apellido + " " + p.Dni);
      }
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      //si se presiona el boton guardar, lo quemamos en el serializer
      XmlWriter writer;
      XmlSerializer ser;

      //Se indica ubicación del archivo XML y su codificación.
      writer = new XmlTextWriter("Mi Archivo", Encoding.ASCII);
      //Se indica el tipo de objeto ha serializar.
      ser = new XmlSerializer(typeof(List<Personas>));
      //Serializa el objeto p en el archivo contenido en writer.
      ser.Serialize(writer,personas);
      //Se cierra la conexión al archivo
      writer.Close();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      //aca leer los datos y setear el list box
      XmlReader reader;
      XmlSerializer ser;

      //Se indica ubicación del archivo XML.
      reader = new XmlTextReader ("Mi Archivo");
      //Se indica el tipo de objeto ha serializar.
      ser = new XmlSerializer(typeof(List<Personas>));
      //Deserializa el archivo contenido en reader, lo guarda en aux.
      personas = (List<Personas>)ser.Deserialize(reader);
      //Se cierra el objeto reader.
      reader.Close();
    }
  }
}
