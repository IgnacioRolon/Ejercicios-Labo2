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
  public partial class frmEstanteria : Form
  {
    public List<Object> estanterias;
    public frmEstanteria(List<Object> estanterias)
    {
      InitializeComponent();
      this.estanterias = new List<Object>();
      this.estanterias = estanterias;
    }

    private void frmEstanteria_Load(object sender, EventArgs e)
    {
        
    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
      if(cmbParametro.Text == "Alimenticio")
      {
        this.estanterias.Add(new Estanteria<Alimenticio>(int.Parse(txtTamano.Text)));
      }
      else
      {
        this.estanterias.Add(new Estanteria<Ferreteria>(int.Parse(txtTamano.Text)));
      }
    }

    private void frmEstanteria_FormClosing(object sender, FormClosingEventArgs e)
    {
      
    }

    private void frmEstanteria_FormClosed(object sender, FormClosedEventArgs e)
    {
      
    }

    private void btnCerrar_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.OK;
    }
  }
}
