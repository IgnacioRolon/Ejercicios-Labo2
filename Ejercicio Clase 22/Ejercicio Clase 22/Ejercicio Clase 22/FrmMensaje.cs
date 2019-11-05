using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Clase_22
{
  public partial class FrmMensaje : Form
  {
    public FrmMensaje()
    {
      InitializeComponent();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    public void MostrarMensaje(string mensaje)
    {
      textBox1.Text = mensaje;
    }
  }
}
