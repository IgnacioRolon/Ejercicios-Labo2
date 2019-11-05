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
  public delegate void mensaje(string mensaje);

  public partial class FrmPrincipal : Form
  {
    public FrmPrincipal()
    {
      InitializeComponent();
    }

    private void btnMostrar1_Click(object sender, EventArgs e)
    {
      foreach (Form form in this.MdiChildren)
      {
        if (form is FrmAccion)
        {
          form.Focus();
          return;
        }
      }
      FrmAccion accion = new FrmAccion();
      accion.MdiParent = this;
      foreach (Form form in this.MdiChildren)
      {
        if (form is FrmMensaje)
        {
          accion.EnviarMensaje -= (form as FrmMensaje).MostrarMensaje;
          accion.EnviarMensaje += (form as FrmMensaje).MostrarMensaje;
        }
      }
      accion.Show();
    }

    private void btnMostrar2_Click(object sender, EventArgs e)
    {
      foreach(Form form in this.MdiChildren)
      {
        if(form is FrmMensaje)
        {
          form.Focus();
          return;
        }
      }      
      FrmMensaje mensaje = new FrmMensaje();
      mensaje.MdiParent = this;      
      mensaje.Show();
    }
  }
}
