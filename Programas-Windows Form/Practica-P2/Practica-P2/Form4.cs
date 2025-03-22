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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Abrir_Click(object sender, EventArgs e)
        {
            string r;
            openFileDialog1.ShowDialog();
            System.IO.StreamReader archivo = new System.IO.StreamReader(openFileDialog1.FileName);
            r = archivo.ReadLine();
            richTextBox1.Text = r.ToString();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "Sin Titulo.txt";
            var guardar = saveFileDialog1.ShowDialog();
            if (guardar == DialogResult.OK)
            {
                using (var guardar_archivo = new System.IO.StreamWriter(saveFileDialog1.FileName))
                {
                    guardar_archivo.WriteLine(richTextBox1.Text);
                }
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void Atras_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void Adelante_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void Copiar_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void Cortar_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void Pegar_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void SeleccionarTodo_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void EliminarTodo_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void Color_Click(object sender, EventArgs e)
        {
            var cl = colorDialog1.ShowDialog();
            if(cl == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void Formato_Click(object sender, EventArgs e)
        {
            var frmt = fontDialog1.ShowDialog();
            if(frmt == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void seleccionar_tamaño(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText !="")
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.SystemFontName, float.Parse 
             (ComboBox1.SelectedItem.ToString()), richTextBox1.Font.Style);
            }
        }
    }
}
