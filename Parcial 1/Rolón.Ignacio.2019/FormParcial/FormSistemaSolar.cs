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

namespace FormParcial
{
    public partial class FormSistemaSolar : Form
    {
        public static List<Astro> planetas;
        public FormSistemaSolar()
        {
            InitializeComponent();
            planetas = new List<Astro>();
            cmbTipoPlaneta.DataSource = Enum.GetNames(typeof(Tipo));
        }

        private void btnAgregarPlaneta_Click(object sender, EventArgs e)
        {
            if(txtNombrePlaneta.Text != "" && txtOrbitaPlaneta.Text != "" && txtOrbitaPlaneta.Text != "" && numRotacionPlaneta.Value > 0 && numCantidadLunas.Value >= 0)
            {
                Tipo tipoPlaneta;
                if (cmbTipoPlaneta.SelectedItem.ToString() == Tipo.Gaseoso.ToString())
                {
                    tipoPlaneta = Tipo.Gaseoso;
                }
                else
                {
                    tipoPlaneta = Tipo.Rocoso;
                }
                Planeta planetaActual = new Planeta(int.Parse(txtOrbitaPlaneta.Text), int.Parse(numRotacionPlaneta.Value.ToString()), txtNombrePlaneta.Text, int.Parse(numCantidadLunas.Value.ToString()), tipoPlaneta);
                planetas.Add(planetaActual);
                //cmbPlanetas.Items.Add(planetaActual.ToString());
                cmbPlanetas.DataSource = null;
                cmbPlanetas.DataSource = planetas;
            }
        }

        private void btnAgregarSatelite_Click(object sender, EventArgs e)
        {
            if(txtNombreSatelite.Text != "" && cmbPlanetas.SelectedItem.ToString() != "" && numOrbitaSatelite.Value > 0 && numRotacionSatelite.Value > 0)
            {
                Astro[] arrayPlanetas = planetas.ToArray();
                for(int i = 0;i<planetas.Count;i++)
                {
                    if (arrayPlanetas[i].ToString() == cmbPlanetas.SelectedItem.ToString())
                    {
                        Satelite satelite = new Satelite(int.Parse(numOrbitaSatelite.Value.ToString()), int.Parse(numRotacionSatelite.Value.ToString()), txtNombreSatelite.Text);
                        arrayPlanetas[i] = (arrayPlanetas[i] as Planeta) + satelite;
                    }
                }
                planetas = arrayPlanetas.ToList<Astro>();
            }
        }

        private void btnMostrarInfo_Click(object sender, EventArgs e)
        {
            StringBuilder str = new StringBuilder();
            foreach(Planeta item in planetas)
            {
                str.AppendLine(item.ToString());
                str.AppendLine();
            }
            rtbInformacion.Clear();
            rtbInformacion.Text = str.ToString();
        }

        private void btnMoverAstros_Click(object sender, EventArgs e)
        {
            rtbInformacion.Clear();
            StringBuilder str = new StringBuilder();
            foreach(Planeta item in planetas)
            {
                str.AppendLine(item.Rotar());
                str.AppendLine(item.Orbitar());
                foreach(Satelite satelite in item.Satelites)
                {
                    str.AppendLine(satelite.Rotar());
                    str.AppendLine(satelite.Orbitar());
                }
            }
            rtbInformacion.Text = str.ToString();
        }
    }
}
