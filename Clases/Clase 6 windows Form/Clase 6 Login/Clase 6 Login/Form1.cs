using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_6_Login
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnContinuar_Click(object sender, EventArgs e)
    {
      //TEXBOX

      //MessageBox.Show(this.tbApellido.Text);

      //CHECK BOX

      //MessageBox.Show(this.ckRecordar.CheckState.ToString()); //muestra el estado actual del check box y lo convierte en string
      //MessageBox.Show(this.ckRecordar.Checked.ToString());  //el estado actual sumando hasta el tercer estado (azul) que es indeterminado
      /*
      if (this.ckRecordar.Checked)
      {
        MessageBox.Show("recordando contraseña");
      }
      */

      //RADIO BUTTON

      //rboHombre.Checked = radioButton1.Checked;   //<---- al tener checkeado el rediobuton 1 y poner continuar (click en boton)
      //se igualara el valor del radio button

      //LIST BOX

      //this.lstPaises.SelectedIndex        //<---- seleccion por indice    da -1 si no hay nada seleccionado
      //this.lstPaises.SelectedItem         //<---- objetos


      //listas
      //cmbCaracteristicas.items.ad("+2");



    }

    private void ckRecordar_CheckedChanged(object sender, EventArgs e)
    {


    }

    private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
    {

    }

    private void lstPaises_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void cmbCaracteristicas_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
  }
}
