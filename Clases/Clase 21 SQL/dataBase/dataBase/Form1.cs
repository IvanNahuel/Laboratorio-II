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
      SqlCommand cm = new SqlCommand("Select id, nombre from provincias", cn);

      cn.Open();

      SqlDataReader dr = cm.ExecuteReader();
      
      while (dr.Read())     //mientras mi data reader pueda leer
      {
        //dr["nombre"].ToString();  //nos devolvera el nombre
        //nos llena la lista con lo que haya en la base de datos
        provincias.Add(new Provincia((int)(decimal)dr["id"], dr["nombre"].ToString()));
      }
      cn.Close();

      this.cmbPcia.DataSource = provincias;

    }
  }
}
