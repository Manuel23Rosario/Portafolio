using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_IMC
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double resultado_Pies, resultadopulgadas, resultado_final, resultado_peso, Pies, Pulgadas, peso;

            Pies = double.Parse(txtPies.Text);
            Pulgadas = double.Parse(txtPulgadas.Text);
            peso = double.Parse(txtPeso.Text);

            resultado_Pies = Pies * 12;

            resultadopulgadas = resultado_Pies + Pulgadas;

            resultado_final = resultadopulgadas * 0.0254;

            txt_resultado_altura.Text = resultado_final.ToString("F2");
            lbl_altura.Visible = true;
            lbl_altura.Text = resultado_final.ToString("Metros");

            resultado_peso = peso / 2.20462262;

            txt_resultado_peso.Text = resultado_peso.ToString("F2");
            lbl_peso.Visible = true;
            lbl_peso.Text = peso.ToString("Kilogramos");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
