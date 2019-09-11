using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moneda;

namespace WindowsFormsApp1
{
  public partial class Form1 : Form
  {
    Pesos cantidadPesos;
    Dolar cantidadDolar;
    Euro cantidadEuro;
    public Form1()
    {
      InitializeComponent();
    }

    private void btnLockear_Click(object sender, EventArgs e)
    {
      if(txtLockPeso.Enabled == true)
      {
        btnLockear.Text = "Unlock";
        txtLockPeso.Enabled = false;
        txtLockDolar.Enabled = false;
        txtLockEuro.Enabled = false;
      }else
      {
        btnLockear.Text = "Lock";
        txtLockPeso.Enabled = true;
        txtLockDolar.Enabled = true;
        txtLockEuro.Enabled = true;
      }
    }


    private void btnEuroCarga_Click(object sender, EventArgs e)
    {
      if(Double.TryParse(txtEuroCarga.Text, out double cargaParseada))
      {
        if(Double.TryParse(txtLockEuro.Text, out double cotizacionEuro) && Double.TryParse(txtLockPeso.Text, out double cotizacionPeso) && Double.TryParse(txtLockDolar.Text, out double cotizacionDolar))
        {
          cantidadEuro = new Euro(cargaParseada, cotizacionEuro);
          cantidadDolar = new Dolar(1, cotizacionDolar);
          cantidadPesos = new Pesos(1, cotizacionPeso);

          cantidadDolar = (Dolar)cantidadEuro;
          cantidadPesos = (Pesos)cantidadEuro;
          txtEuro1.Text = cargaParseada.ToString();
          txtDolar1.Text = cantidadDolar.GetCantidad().ToString();
          txtPeso1.Text = cantidadPesos.GetCantidad().ToString();
        }
      }
    }

    private void txtLockDolar_TextChanged(object sender, EventArgs e)
    {

    }

    private void btnDolarCarga_Click(object sender, EventArgs e)
    {
      if (Double.TryParse(txtDolarCarga.Text, out double cargaParseada))
      {
        if (Double.TryParse(txtLockEuro.Text, out double cotizacionEuro) && Double.TryParse(txtLockPeso.Text, out double cotizacionPeso) && Double.TryParse(txtLockDolar.Text, out double cotizacionDolar))
        {
          cantidadEuro = new Euro(1, cotizacionEuro);
          cantidadDolar = new Dolar(cargaParseada, cotizacionDolar);
          cantidadPesos = new Pesos(1, cotizacionPeso);

          cantidadEuro = (Euro)cantidadDolar;
          cantidadPesos = (Pesos)cantidadDolar;
          txtDolar2.Text = cargaParseada.ToString();
          txtEuro2.Text = cantidadEuro.GetCantidad().ToString();
          txtPeso2.Text = cantidadPesos.GetCantidad().ToString();
        }
      }
    }

    private void txtLockEuro_TextChanged(object sender, EventArgs e)
    {
      
    }

    private void txtLockEuro_Leave(object sender, EventArgs e)
    {
      if (!Double.TryParse(txtLockEuro.Text, out double checkDouble))
      {
        MessageBox.Show("Valor de Cotización Invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        txtLockEuro.Focus();
      }
    }

    private void txtLockPeso_Leave(object sender, EventArgs e)
    {
      if (!Double.TryParse(txtLockPeso.Text, out double checkDouble))
      {
        MessageBox.Show("Valor de Cotización Invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        txtLockPeso.Focus();
      }
    }

    private void btnPesoCarga_Click(object sender, EventArgs e)
    {
      if (Double.TryParse(txtPesoCarga.Text, out double cargaParseada))
      {
        if (Double.TryParse(txtLockEuro.Text, out double cotizacionEuro) && Double.TryParse(txtLockPeso.Text, out double cotizacionPeso) && Double.TryParse(txtLockDolar.Text, out double cotizacionDolar))
        {
          cantidadEuro = new Euro(1, cotizacionEuro);
          cantidadDolar = new Dolar(1, cotizacionDolar);
          cantidadPesos = new Pesos(cargaParseada, cotizacionPeso);

          cantidadEuro = (Euro)cantidadPesos;
          cantidadDolar = (Dolar)cantidadPesos;
          txtDolar3.Text = cantidadDolar.GetCantidad().ToString();
          txtEuro3.Text = cantidadEuro.GetCantidad().ToString();
          txtPeso3.Text = cargaParseada.ToString();
        }
      }
    }
  }
}
