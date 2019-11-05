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
  public partial class FrmAccion : Form
  {
    public event mensaje EnviarMensaje;
    public FrmAccion()
    {
      InitializeComponent();
    }

    private void btnMostrar1_Click(object sender, EventArgs e)
    {
      if(textBox1.Text != "")
      {
        EnviarMensaje.Invoke(textBox1.Text);
      }
    }
  }
}
