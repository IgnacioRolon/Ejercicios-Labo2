using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjercicioClaseArchivosBiblioteca;

namespace EjercicioClaseArchivos
{
  public partial class Form1 : Form
  {
    private List<Mensaje> mensajes;
    public Form1()
    {
      InitializeComponent();
      mensajes = new List<Mensaje>();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    private void btnEnviar_Click(object sender, EventArgs e)
    {
      Mensaje mensajeActual = new Mensaje(txtUsuario.Text, txtMensaje.Text, DateTime.Now);
      mensajes.Add(mensajeActual);
      txtMensaje.Text = "";
      foreach(Mensaje item in mensajes)
      {
        item.Serializar();
      }
      btnRefresh_Click(this, e);
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
      lstMensajes.DataSource = null;
      lstMensajes.DataSource = Mensaje.Deserializar();
      lstMensajes.SelectedIndex = -1;

      StreamWriter sw = new StreamWriter("Archivo.log");
      sw.WriteLine("[{0}] - Se ha refrescado la lista de mensajes.", DateTime.Now);
      sw.Close();
    }

    private void txtMensaje_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        btnEnviar_Click(this, new EventArgs());
      }
    }

    private void Form1_KeyPress(object sender, KeyPressEventArgs e)
    {
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F5)
      {
        btnRefresh_Click(this, new EventArgs());
      }
    }
  }
}
