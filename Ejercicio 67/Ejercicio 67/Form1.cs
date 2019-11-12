using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Ejercicio_67
{
    public partial class Form1 : Form
    {
        private bool flag;
        private Temporizador temporizador;
        private int contador = 0;
        Random value = new Random();
        public Form1()
        {
            InitializeComponent();
            flag = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(flag == false)
            {
                temporizador = new Temporizador();
                temporizador.eventoTiempo += OtroMetodo;
                temporizador.Intervalo = int.Parse(textBox1.Text);
                temporizador.Activo = true;
            }
            else
            {
                temporizador.Activo = false;
            }

            flag = !flag;
        }

        private void TestTiempo()
        {
            MessageBox.Show("Hello");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            temporizador.Intervalo = int.Parse(textBox1.Text);
        }


        delegate void Callback();
        public void OtroMetodo()
        {            
            if (this.pictureBox1.InvokeRequired || this.pictureBox2.InvokeRequired)
            {
                Callback d = new Callback(this.OtroMetodo);
                this.Invoke(d);
            }
            else
            {
                Point point = new Point(pictureBox1.Location.X + value.Next(0, 10), pictureBox1.Location.Y);
                pictureBox1.Location = point;

                Thread.Sleep(50);

                Point point2 = new Point(pictureBox2.Location.X + value.Next(0, 10), pictureBox2.Location.Y);
                pictureBox2.Location = point2;

                if((pictureBox1.Location.X + pictureBox1.Width) > this.Width)
                {
                    MessageBox.Show("Pic 1 won!");
                    temporizador.Activo = false;
                }else if((pictureBox2.Location.X + pictureBox2.Width) > this.Width)
                {
                    MessageBox.Show("Pic 2 won!");
                    temporizador.Activo = false;
                }
            }
        }
    }
}
