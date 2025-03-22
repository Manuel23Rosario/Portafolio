namespace Calculadora_IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double IMC, altura, peso;

            altura = double.Parse(txt_altura.Text);
            peso = double.Parse(txt_peso.Text);

            IMC = peso / altura;
            MessageBox.Show("Tu IMC es: " + IMC.ToString("F2"));

        }

        private void btn_peso_altura_Click(object sender, EventArgs e)
        {
            Form2 segundoformulario = new Form2();

            segundoformulario.ShowDialog();
        }
    }
}
