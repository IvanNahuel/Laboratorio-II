using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace dataBase
{
  public partial class Form1 : Form
  {
    List<Provincia> provincias;

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

      provincias = new List<Provincia>();

      // MessageBox.Show(Properties.Settings.Default.BDSQL);
      //inicia la conexcion 
      SqlConnection cn = new SqlConnection(Properties.Settings.Default.BDSQL);
      //prepara el comando a ejecutar en la base de datos
      SqlCommand cm = new SqlCommand("Select id, nombre from provincia", cn);

      SqlCommand cm3 = new SqlCommand("insert into provincia (nombre)values('Santiago Del Estero')", cn);

      //
      //cm3.ExecuteNonQuery() para insert o update ( para modificar la base de datos)

      cn.Open();

      SqlDataReader dr = cm.ExecuteReader();

      while (dr.Read())     //mientras mi data reader pueda leer
      {
        //dr["nombre"].ToString();  //nos devolvera el nombre
        //nos llena la lista con lo que haya en la base de datos
        provincias.Add(new Provincia((int)(decimal)dr["id"], dr["nombre"].ToString()));
      }

      this.cmbPcia.DataSource = provincias;

      cn.Close();

    }

    public string ChangedStateInComboBoxLocalidades()
    {
      return this.cmbPcia.Text;
    }

    private void cmbLocalidad_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void cmbLocalidad_Click(object sender, EventArgs e)
    {
      int idAux = new int();
      //le pasamos un elemento de la lista y me tiene que retornar si id de la base de datos
      foreach (Provincia prov in provincias)
      {
        if (ChangedStateInComboBoxLocalidades() == prov.Nombre)
        {
          idAux = prov.Id;
        }
      }
      //-------------------------------------------------------------------------------------------
      
      SqlConnection sqlcn2 = new SqlConnection(Properties.Settings.Default.BDSQL);

      string auxConsulta = "select id, Provincia, nombre from Localidades where Localidades.provincia = " + idAux.ToString();
      //la consulta, nos retorna la tabla entera, en base a valga la redundancia, su comando "CONSULTA"
      SqlCommand sqlcm2 = new SqlCommand(auxConsulta , sqlcn2);

      sqlcn2.Open();

      SqlDataReader dr2 = sqlcm2.ExecuteReader();

      List<Localides> localidesAux = new List<Localides>();

      while (dr2.Read())
      {
        localidesAux.Add(new Localides((int)(decimal)dr2["id"], (int)(decimal)dr2["provincia"], dr2["nombre"].ToString()));
      }
      this.cmbLocalidad.DataSource = localidesAux;
    }
  }
}
