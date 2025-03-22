using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_P2
{
    public partial class Form2 : Form
    {
        double primero;
        double segundo;
        string operador;
        public Form2()
        {
            InitializeComponent();
        }

        Clases.ClassSum obj = new Clases.ClassSum();
        Clases.ClassRes obj2 = new Clases.ClassRes();
        Clases.ClassMulti obj3 = new Clases.ClassMulti();
        Clases.ClassDiv obj4 = new Clases.ClassDiv();

        private void btn_0_Click(object sender, EventArgs e)
        {
            tbx_resultado.Text = tbx_resultado.Text + "0";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            tbx_resultado.Text = tbx_resultado.Text + "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            tbx_resultado.Text = tbx_resultado.Text + "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            tbx_resultado.Text = tbx_resultado.Text + "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            tbx_resultado.Text = tbx_resultado.Text + "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            tbx_resultado.Text = tbx_resultado.Text + "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            tbx_resultado.Text = tbx_resultado.Text + "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            tbx_resultado.Text = tbx_resultado.Text + "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            tbx_resultado.Text = tbx_resultado.Text + "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            tbx_resultado.Text = tbx_resultado.Text + "9";
        }

        private void btn_deci_Click(object sender, EventArgs e)
        {
            tbx_resultado.Text = tbx_resultado.Text + ".";
        }

        private void btn_suma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(tbx_resultado.Text);
            tbx_resultado.Clear();
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            operador = "X";
            primero = double.Parse(tbx_resultado.Text);
            tbx_resultado.Clear();
        }

        private void btn_resta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(tbx_resultado.Text);
            tbx_resultado.Clear();
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(tbx_resultado.Text);
            tbx_resultado.Clear();
        }

        private void btn_resultado_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(tbx_resultado.Text);

            double Sum;
            double Res;
            double Multi;
            double Div;

            switch(operador)
            {
                case "+":
                    Sum = obj.Sumar((primero), (segundo));
                    tbx_resultado.Text = Sum.ToString();
                    break;

                case "-":
                    Res = obj2.Resta((primero), (segundo));
                    tbx_resultado.Text = Res.ToString();
                    break;

                case "X":
                    Multi = obj3.Multi((primero), (segundo));
                    tbx_resultado.Text = Multi.ToString();
                    break;

                case "/":
                    Div = obj4.Divicion((primero), (segundo));
                    tbx_resultado.Text = Div.ToString();
                    break;
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            tbx_resultado.Clear();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (tbx_resultado.Text.Length == 1)
                tbx_resultado.Text = "";
            else
                tbx_resultado.Text = tbx_resultado.Text.Substring(0, tbx_resultado.Text.Length - 1);
        }
    }
}
