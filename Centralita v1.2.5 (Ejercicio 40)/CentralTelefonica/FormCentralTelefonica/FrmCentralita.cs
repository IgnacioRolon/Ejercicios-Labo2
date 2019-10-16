using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace FormCentralTelefonica
{
  public partial class frmCentralitaMain : Form
  {
    public Centralita centralita;
    public frmCentralitaMain()
    {
      InitializeComponent();
    }
    public Centralita Centralita
    {
      get
      {
        return this.centralita;
      }
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void btnGenerar_Click(object sender, EventArgs e)
    {

    }
  }
}
