using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCentralTelefonica
{
  public partial class FrmLlamador : Form
  {
    public FrmLlamador()
    {
      InitializeComponent();
    }

    private void btn1_Click(object sender, EventArgs e)
    {
      txtDestino.Text += 1;
    }

    private void btn2_Click(object sender, EventArgs e)
    {
      txtDestino.Text += 2;
    }

    private void btn3_Click(object sender, EventArgs e)
    {
      txtDestino.Text += 3;
    }

    private void btn4_Click(object sender, EventArgs e)
    {
      txtDestino.Text += 4;
    }

    private void btn5_Click(object sender, EventArgs e)
    {
      txtDestino.Text += 5;
    }

    private void btn6_Click(object sender, EventArgs e)
    {
      txtDestino.Text += 6;
    }

    private void btn7_Click(object sender, EventArgs e)
    {
      txtDestino.Text += 7;
    }

    private void btn8_Click(object sender, EventArgs e)
    {
      txtDestino.Text += 8;
    }

    private void btn9_Click(object sender, EventArgs e)
    {
      txtDestino.Text += 9;
    }

    private void btnAsterisco_Click(object sender, EventArgs e)
    {
      txtDestino.Text += "*";
    }

    private void btn0_Click(object sender, EventArgs e)
    {
      txtDestino.Text += 0;
    }

    private void btnNumeral_Click(object sender, EventArgs e)
    {
      txtDestino.Text += "#";
    }
  }
}
