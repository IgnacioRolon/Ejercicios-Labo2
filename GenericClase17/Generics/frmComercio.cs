using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Generics
{
  public partial class frmComercio : Form
  {
    public List<Object> estanterias;
    public frmComercio(List<Object> estanteria)
    {
      InitializeComponent();
      estanterias = new List<Object>();
      estanterias = estanteria;
      cmbEstanteria.DataSource = estanterias;
    }

    public frmComercio()
    {
      InitializeComponent();
      estanterias = new List<Object>();      
    }

    private void btnCrear_Click(object sender, EventArgs e)
    {
      frmEstanteria estanteria = new frmEstanteria(estanterias);
      if(estanteria.ShowDialog() == DialogResult.OK)
      {
        this.estanterias = estanteria.estanterias;
        foreach(Object item in this.estanterias)
        {
          cmbEstanteria.Items.Add(item.ToString());
        }
      }      
    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {

    }
  } 
}
