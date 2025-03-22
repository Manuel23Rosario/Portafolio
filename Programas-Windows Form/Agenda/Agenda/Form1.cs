using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;


namespace Agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<ClassContacto> Agenda = new List<ClassContacto>();

        SqlConnection conexion = new SqlConnection("server=LAPTOP-NANT6IM3;database=AgendaP2; integrated security=true");

        //Leer los datos de la base de datos
        private void Form1_Load(object sender, EventArgs e)
        {
            string consulta = "Select * From Contactos";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgvAgenda.DataSource = dt;
        }



        private void dgvAgenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Id.Text = dgvAgenda.SelectedCells[0].Value.ToString();
            txt_Nombre.Text = dgvAgenda.SelectedCells[1].Value.ToString();
            txt_Apellido.Text = dgvAgenda.SelectedCells[2].Value.ToString();
            txt_Fecha.Text = dgvAgenda.SelectedCells[3].Value.ToString();
            txt_Direccion.Text = dgvAgenda.SelectedCells[4].Value.ToString();
            cboGenero.Text = dgvAgenda.SelectedCells[5].Value.ToString();
            cbo_Estado_Civil.Text = dgvAgenda.SelectedCells[6].Value.ToString();
            txt_Movil.Text = dgvAgenda.SelectedCells[7].Value.ToString();
            txt_Telefono.Text = dgvAgenda.SelectedCells[8].Value.ToString();
            txt_Correo.Text = dgvAgenda.SelectedCells[9].Value.ToString();
        }
        //Con esto hacemos que la tabla se actualice cada que agregamos, modificamos o borramos algo
        public void llenar_tabla()
        {
            string consulta = "Select * From Contactos";
        SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
        DataTable dt = new DataTable();
        adaptador.Fill(dt);
            dgvAgenda.DataSource = dt;
        }

        private void LimpiarCampos()
        {
            txt_Nombre.Clear();  
            txt_Apellido.Clear();  
            txt_Direccion.Clear();  
            txt_Movil.Clear();  
            txt_Telefono.Clear();  
            txt_Correo.Clear();  
            cboGenero.SelectedIndex = -1;  
            cbo_Estado_Civil.SelectedIndex = -1;
        }
        //Aqui nos aseguramos de validar los campos y no se envien campos vacios
        private bool ValidarCampos()
        {
        if (string.IsNullOrWhiteSpace(txt_Nombre.Text))
        {
        MessageBox.Show("El campo 'Nombre' es obligatorio");
                txt_Nombre.Focus();
                return false; 
        }

            if (string.IsNullOrWhiteSpace(txt_Apellido.Text))
            {
                MessageBox.Show("El campo 'Apellido' es obligatorio");
                txt_Apellido.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_Movil.Text))
            {
                MessageBox.Show("El campo 'Movil' es obligatorio");
                txt_Movil.Focus();
                return false;
            }

            if (cboGenero.SelectedIndex == -1)
            {
                MessageBox.Show("El campo 'Genero' es obligatorio");
                cboGenero.Focus();
                return false;
            }

            if (cbo_Estado_Civil.SelectedIndex == -1)
            {
                MessageBox.Show("El campo 'Estado Civil' es obligatorio");
                cbo_Estado_Civil.Focus();
                return false;
            }

            if (!ValidarCorreoElectronico(txt_Correo.Text))
            {
                MessageBox.Show("El correo electrónico no tiene un formato válido.");
                txt_Correo.Focus();
                return false;
            }

            if (!ValidarNumeroMovil(txt_Movil.Text))
            {
                MessageBox.Show("El número de móvil debe contener solo dígitos y al menos 10 caracteres.");
                txt_Movil.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_Fecha.Text))
            {
                txt_Fecha.Focus();
                return false;
            }


            return true;

        }

        private bool ValidarCorreoElectronico(string correo)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(correo);
                return addr.Address == correo;
            }
            catch
            {
                return false;
            }
        }

        private bool ValidarNumeroMovil(string movil)
        {
            return movil.All(char.IsDigit) && movil.Length >= 10;
        }


        


        //Boton Insertar
        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            // Validar campos antes de Modificar el registro
            if (!ValidarCampos())
            {
                return;
            }
            try
            {
                conexion.Open();

                string consulta = "INSERT INTO Contactos (Nombre, Apellido, FechaNacimiento, Direccion, EstadoCivil, Genero, Movil, Telefono, CorreoElectronico) " +
                     "VALUES (@Nombre, @Apellido, @FechaNacimiento, @Direccion, @EstadoCivil, @Genero, @Movil, @Telefono, @Correo)";
                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    cmd.Parameters.AddWithValue("@Nombre", txt_Nombre.Text);
                    cmd.Parameters.AddWithValue("@Apellido", txt_Apellido.Text);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", txt_Fecha.Text);  // Extrae el valor de DateTimePicker
                    cmd.Parameters.AddWithValue("@Direccion", txt_Direccion.Text);
                    cmd.Parameters.AddWithValue("@EstadoCivil", cbo_Estado_Civil.SelectedItem.ToString());  // Asegúrate de que seleccionas el ítem correcto
                    cmd.Parameters.AddWithValue("@Genero", cboGenero.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Movil", txt_Movil.Text);
                    cmd.Parameters.AddWithValue("@Telefono", txt_Telefono.Text);
                    cmd.Parameters.AddWithValue("@Correo", txt_Correo.Text);

                    // Ejecutar el comando
                    cmd.ExecuteNonQuery();

                }
                MessageBox.Show("Registro Guardado");
                llenar_tabla();
                // Cerrar la conexión
                conexion.Close();
            }

             catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
           


        //Boton Modificar
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();

                string consulta = "update Contactos set Nombre='" + txt_Nombre.Text + "',Apellido='" + txt_Apellido.Text + "',FechaNacimiento='" + txt_Fecha.Text + "',Direccion='" + txt_Direccion.Text + "',EstadoCivil='" + cbo_Estado_Civil.Text + "',Genero='" + cboGenero.Text + "',Movil='" + txt_Movil.Text + "',Telefono='" + txt_Telefono.Text + "',CorreoElectronico='" + txt_Correo.Text + "' where Id=" + txt_Id.Text + "";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                int cantidad;
                cantidad = comando.ExecuteNonQuery();
                if (cantidad > 0)
                {
                    MessageBox.Show("Registro Modificado");
                }
                llenar_tabla();

                conexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        //Boton Buscar
        private void btn_buscar_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txt_buscar.Text))
            {
                MessageBox.Show("Ingrese un nombre para buscar.");
                return;
            }

            try
            {
                using (SqlConnection conexion = new SqlConnection("server=LAPTOP-NANT6IM3;database=AgendaP2; integrated security=true"))
                {
                    conexion.Open();

                    string consulta = "SELECT * FROM Contactos WHERE Nombre = @nombre";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    adaptador.SelectCommand.Parameters.AddWithValue("@nombre", txt_buscar.Text);

                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dgvAgenda.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        //Boton Eliminar
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();

                string consulta = "delete from Contactos where Id=" + txt_Id.Text + "";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro Eliminado");
                llenar_tabla();

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void dgvAgenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}


