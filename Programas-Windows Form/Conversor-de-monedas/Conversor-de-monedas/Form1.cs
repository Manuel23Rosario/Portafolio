namespace Conversor_de_monedas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cob_convert_SelectedIndexChanged(object sender, EventArgs e)
        {
            Double Pesos, Dolar, Euro, Yen, LibraEs;

            Pesos = Convert.ToDouble(txt_pesos.Text);

            if (cob_convert.SelectedIndex == 0)
            {
                Dolar = Pesos * 60.40;
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Dolares";
                txt_resultado.Text = Convert.ToString(Dolar);
            }
            else if (cob_convert.SelectedIndex == 1)
            {
                Euro = Pesos * 66.08;
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Euros";
                txt_resultado.Text = Convert.ToString(Euro);
            }
            else if (cob_convert.SelectedIndex == 2)
            {
                Yen = Pesos * 0.41;
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Yen Japones";
                txt_resultado.Text = Convert.ToString(Yen);
            }
            else
            {
                LibraEs = Pesos * 78.92;
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Libras Esterlinas";
                txt_resultado.Text = Convert.ToString(LibraEs);
            }

        }

        private void cob_convert_Click(object sender, EventArgs e)
        {
            if (txt_pesos.Text.Length == 0)
            {
                MessageBox.Show("Debe de ingresar una cantidad.");

                txt_pesos.Text = "";
                txt_resultado.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
