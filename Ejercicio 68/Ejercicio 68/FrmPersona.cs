using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_68
{
  public partial class FrmPersona : Form
  {
    private Persona persona;

    public FrmPersona()
    {
      InitializeComponent();
    }

    private void btnCrear_Click(object sender, EventArgs e)
    {
      if(persona == null)
      {
        persona = new Persona();
        persona.EventoString += NotificarCambio;
        persona.Nombre = txtNombre.Text;
        persona.Apellido = txtApellido.Text;
        btnCrear.Text = "Actualizar";
      }
      else
      {
        if(txtNombre.Text != "" && txtNombre.Text != persona.Nombre)
        {
          persona.Nombre = txtNombre.Text;
        }
        if (txtApellido.Text != "" && txtApellido.Text != persona.Apellido)
        {
          persona.Apellido = txtApellido.Text;
        }
      }
      MessageBox.Show("Se ha creado/cambiado la persona: " + persona.Mostrar(), "Persona Creada/Cambiada", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public void NotificarCambio(string mensaje)
    {
      MessageBox.Show(mensaje);
    }

    private void FrmPersona_Load(object sender, EventArgs e)
    {
      
    }
  }
}
