using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataBase
{
  public class Localides
  {
    int id;
    int provincia;
    string nombre;

    public int Id {
      get { return this.id; }
      set { this.id = value; }
    }
    public int Provincia
    {
      get { return this.provincia; }
      set { this.provincia = value; }
    }
    public string Nombre
    {
      get { return this.nombre; }
      set { this.nombre = value; }
    }
    public override string ToString()
    {
      return this.nombre;
    }
    public Localides(int id, int provincia,string nombre)
    {
      this.Id = id;
      this.Provincia = provincia;
      this.Nombre = nombre;
    }
  }
}
