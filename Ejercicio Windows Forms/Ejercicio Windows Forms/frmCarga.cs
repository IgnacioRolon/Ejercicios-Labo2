using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Windows_Forms
{
  public partial class frmCarga : Form
  {
    public Persona[] arrayPersonas;
    public frmCarga()
    {
      InitializeComponent();
      arrayPersonas = new Persona[3];
    }

    public void Limpiar()
    {
      txtNombre.Text = "";
      txtApellido.Text = "";
      txtDni.Text = "";
    }

    private void btnAceptar_Click(object sender, EventArgs e)
    {
      if (DialogResult.Yes == MessageBox.Show("¿Desea agregar la Persona ingresada?", "Ingresar Persona", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
      {
        for (int i = 0;i<3;i++)
        {        
          if (arrayPersonas[i] == null)
          {
            arrayPersonas[i] = new Persona(txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text));
            break;
          }        
        }
      }
      Limpiar();
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      Limpiar();
    }

    private void btnMostrar_Click(object sender, EventArgs e)
    {
      frmMostrar frmMostrar = new frmMostrar();
      frmMostrar.Show(this);
    }
  }
}
