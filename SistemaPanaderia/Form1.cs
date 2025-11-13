using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;


namespace SistemaPanaderia
{
    public partial class Inicio : Form
    {
        MySqlConnection connectionString = new MySqlConnection("server=localhost;user=root;password=;database=panaderia");
        public Inicio()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevaventa_Click(object sender, EventArgs e)
        {
            try
            {
                Form ventas = new Ventas
                {
                    StartPosition = FormStartPosition.CenterScreen
                };
                ventas.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el formaulario de ventas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void descubreNuevosProductosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaPan consultaPan = new ConsultaPan();
            consultaPan.Show();
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();
            ventas.Show();
        }

        private void sobreNosotrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nosotros nosotros = new Nosotros();
            nosotros.Show();
        }

        private void novedadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Novedades novedades = new Novedades();
            novedades.Show();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}

