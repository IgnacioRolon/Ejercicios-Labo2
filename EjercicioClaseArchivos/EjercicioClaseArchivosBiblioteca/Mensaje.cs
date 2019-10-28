using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace EjercicioClaseArchivosBiblioteca
{
  public class Mensaje : IMensaje
  {
    private string usuario;
    private string texto;
    private DateTime hora;
    public Mensaje()
    {
      hora = DateTime.Now;
    }

    public string Usuario { get; set; }
    public string Texto { get; set; }
    public string Hora { get; set; }

    public Mensaje(string usuario, string texto, DateTime hora)
    {
      this.usuario = usuario;
      this.texto = texto;
      this.hora = hora;
    }

    public override string ToString()
    {
      StringBuilder str = new StringBuilder();
      str.AppendFormat("[{0}] {1}: {2}", this.hora.ToShortTimeString(), this.usuario, this.texto);
      return str.ToString();
    }

    public void Serializar()
    {
      string path = @"Y:\mensajes\" + this.usuario + DateTime.Now.ToLongTimeString() + ".xml";
      XmlTextWriter wr = new XmlTextWriter(path,Encoding.ASCII);
      XmlSerializer ser = new XmlSerializer(typeof(Mensaje));
      ser.Serialize(wr, this);
      wr.Close();
    }

    public static List<Mensaje> Deserializar()
    {
      Mensaje aux = new Mensaje();
      XmlTextReader reader = new XmlTextReader(@"Y:\mensajes");
      XmlSerializer ser;
      List<Mensaje> mensajes = new List<Mensaje>();
      foreach (string path in Directory.GetFiles(@"Y:\mensajes"))
      {
        reader = new XmlTextReader(path);
        ser = new XmlSerializer(typeof(Mensaje));
        aux = (Mensaje)ser.Deserialize(reader);
        mensajes.Add(aux);
      }
      reader.Close();
      return mensajes;
    }
  }
}
