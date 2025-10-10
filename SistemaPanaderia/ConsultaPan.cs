using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPanaderia
{
    public partial class ConsultaPan : Form
    {


        // Cadena de conexión para SQL Server (LocalDB)
        //private string connectionString = "Server=localhost;Database=Prueba;Trusted_Connection=True;";

        // Diccionario de panes y sus respectivas imágenes
        private readonly Dictionary<string, string> Resources = new Dictionary<string, string>
{
    { "Quesadilla", "Quesadilla.jpg" },
    { "Peperecha", "Peperecha.jpg" },
    { "Simita alta", "Simita_alta.jpg" },
    { "Concha", "Concha.jpg" },
    { "Salpor", "Salpor.jpg" },
    { "Poleada", "Poleada.jpg" },
    { "Nuevo de chocolate", "Nuevo_de_chocolate.jpg" }
};


        public ConsultaPan()
        {
            InitializeComponent();
        }

        private void ConsultaPan_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Obtener el valor seleccionado en el ComboBox
            string selecedPAN = cmbNombre.SelectedItem.ToString();

            // Consultar la base de datos para obtener el stock y el precio del helado seleccionado
            string query = "SELECT stock, precio FROM helados WHERE nombre = @nombre";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombre", selecedPAN);

                    // Ejecutar la consulta y obtener el resultado
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Si se encuentra el helado, actualizar los controles
                        lbPrecio.Text = "$" + reader["stock"].ToString();
                        lbStock.Text = "" + reader["precio"].ToString();
                    }
                    else
                    {
                        // Si no se encuentra el helado, mostrar un mensaje de error
                        MessageBox.Show("PAN no encontrado en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Manejar errores de conexión o consulta
                    MessageBox.Show("Error al consultar la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

