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

        private string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Panaderia;Trusted_Connection=true;";



        private readonly Dictionary<string, string> Resources = new Dictionary<string, string>
        {
            { "Quesadilla", "Quesadilla.jpeg" },
            { "Peperecha", "Peperecha.jpg" },
            { "Simita alta", "Simita_alta.jpeg" },
            { "Concha", "Concha.jpeg" },
            { "Salpor", "Salpor.jpeg" },
            { "Poleada", "Poleada.jpg" },
            { "Nuevo de chocolate", "Nuevo_de_chocolate.jpg" }
        };

        private ArbolAVL arbolPan;
        private Dictionary<string, (decimal Precio, int Stock)> inventarioHash;
        private GrafoCombinaciones grafoPanes;

        public ConsultaPan()
        {
            InitializeComponent();


            arbolPan = new ArbolAVL();
            inventarioHash = new Dictionary<string, (decimal, int)>();
            grafoPanes = new GrafoCombinaciones();
            InicializarGrafo();
            CargarDatosEnArbol();
        }



        private void ConsultaPan_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (cmbNombre.SelectedItem == null)
            {
                MessageBox.Show("❌ Por favor selecciona un pan de la lista.", "Selección Requerida",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string panSeleccionado = cmbNombre.SelectedItem.ToString();


            var resultado = arbolPan.Buscar(panSeleccionado);

            if (resultado.HasValue)
            {

                lbPrecio.Text = "$" + resultado.Value.Precio.ToString("F2");
                lbStock.Text = resultado.Value.Stock.ToString();

                MostrarImagen(resultado.Value.Imagen);
                MostrarRecomendaciones(panSeleccionado);

                MessageBox.Show($"✅ Información cargada!\n🍞 {panSeleccionado}\n💰 ${resultado.Value.Precio:F2}\n📦 {resultado.Value.Stock} unidades",
                              "Consulta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("❌ PAN no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void InicializarGrafo()
        {
            grafoPanes.AgregarConexion("Concha", "Chocolate", 5);
            grafoPanes.AgregarConexion("Quesadilla", "Café", 4);
            grafoPanes.AgregarConexion("Peperecha", "Atole", 3);
            grafoPanes.AgregarConexion("Simita alta", "Leche", 4);
            grafoPanes.AgregarConexion("Salpor", "Chocolate", 5);
            grafoPanes.AgregarConexion("Nuevo de chocolate", "Leche", 5);
        }

        private void CargarDatosEnArbol()
        {
            try
            {

                string query = "SELECT nombre, precio, stock FROM panes";

                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string nombre = reader["nombre"].ToString();
                        decimal precio = Convert.ToDecimal(reader["precio"]);
                        int stock = Convert.ToInt32(reader["stock"]);
                        string imagen = Resources.ContainsKey(nombre) ? Resources[nombre] : "default.jpg";

                        arbolPan.Insertar(nombre, precio, stock, imagen);
                        inventarioHash[nombre] = (precio, stock);
                    }
                    reader.Close();
                }

                var nombresPan = arbolPan.ObtenerTodosNombres();
                cmbNombre.Items.Clear();
                cmbNombre.Items.AddRange(nombresPan.ToArray());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarImagen(string nombreImagen)
        {
            try
            {
                string[] rutasPosibles = {
                    Path.Combine(Application.StartupPath, "Resources", nombreImagen),
                    Path.Combine(Application.StartupPath, "..", "..", "Resources", nombreImagen),
                    Path.Combine(Application.StartupPath, nombreImagen)
                };

                foreach (string rutaImagen in rutasPosibles)
                {
                    if (File.Exists(rutaImagen))
                    {
                        ptbpanes.Image = Image.FromFile(rutaImagen);
                        ptbpanes.SizeMode = PictureBoxSizeMode.Zoom;
                        return;
                    }
                }
                ptbpanes.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar imagen: " + ex.Message);
                ptbpanes.Image = null;
            }
        }

        private void MostrarRecomendaciones(string panBase)
        {
            var recomendaciones = grafoPanes.ObtenerRecomendaciones(panBase);
            if (recomendaciones.Any())
            {
                string mensaje = $"💡 Combinaciones recomendadas:\n";
                foreach (string rec in recomendaciones)
                    mensaje += $"\n• {rec}";

                MessageBox.Show(mensaje, "🍽️ Recomendaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // AGREGA EL EVENTO DEL COMBOBOX 
        private void cmbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNombre.SelectedItem != null)
            {
                string panSeleccionado = cmbNombre.SelectedItem.ToString();
                var resultado = arbolPan.Buscar(panSeleccionado);

                if (resultado.HasValue)
                {
                    lbPrecio.Text = "$" + resultado.Value.Precio.ToString("F2");
                    lbStock.Text = resultado.Value.Stock.ToString();
                    MostrarImagen(resultado.Value.Imagen);
                }
            }
            else
            {
                lbPrecio.Text = "";
                lbStock.Text = "0";
                ptbpanes.Image = null;
            }
        }
    }



    public class NodoAVL
    {
        public string Clave;
        public decimal Precio;
        public int Stock;
        public string Imagen;
        public NodoAVL Izquierdo, Derecho;
        public int Altura;

        public NodoAVL(string clave, decimal precio, int stock, string imagen)
        {
            Clave = clave;
            Precio = precio;
            Stock = stock;
            Imagen = imagen;
            Altura = 1;
        }
    }

    public class ArbolAVL
    {
        private NodoAVL raiz;

        public void Insertar(string clave, decimal precio, int stock, string imagen)
        {
            raiz = Insertar(raiz, clave, precio, stock, imagen);
        }

        private NodoAVL Insertar(NodoAVL nodo, string clave, decimal precio, int stock, string imagen)
        {
            if (nodo == null) return new NodoAVL(clave, precio, stock, imagen);

            if (string.Compare(clave, nodo.Clave) < 0)
                nodo.Izquierdo = Insertar(nodo.Izquierdo, clave, precio, stock, imagen);
            else if (string.Compare(clave, nodo.Clave) > 0)
                nodo.Derecho = Insertar(nodo.Derecho, clave, precio, stock, imagen);
            else
                return nodo;

            nodo.Altura = 1 + Math.Max(Altura(nodo.Izquierdo), Altura(nodo.Derecho));
            return Balancear(nodo);
        }

        public (decimal Precio, int Stock, string Imagen)? Buscar(string clave)
        {
            var nodo = Buscar(raiz, clave);
            return nodo != null ? (nodo.Precio, nodo.Stock, nodo.Imagen) : null;
        }

        private NodoAVL Buscar(NodoAVL nodo, string clave)
        {
            if (nodo == null) return null;

            int comparacion = string.Compare(clave, nodo.Clave);
            if (comparacion == 0) return nodo;
            return comparacion < 0 ? Buscar(nodo.Izquierdo, clave) : Buscar(nodo.Derecho, clave);
        }

        public List<string> ObtenerTodosNombres()
        {
            var nombres = new List<string>();
            InOrden(raiz, nombres);
            return nombres;
        }

        private void InOrden(NodoAVL nodo, List<string> nombres)
        {
            if (nodo != null)
            {
                InOrden(nodo.Izquierdo, nombres);
                nombres.Add(nodo.Clave);
                InOrden(nodo.Derecho, nombres);
            }
        }

        private int Altura(NodoAVL nodo) => nodo?.Altura ?? 0;
        private int FactorBalance(NodoAVL nodo) => nodo == null ? 0 : Altura(nodo.Izquierdo) - Altura(nodo.Derecho);

        private NodoAVL Balancear(NodoAVL nodo)
        {
            int factor = FactorBalance(nodo);

            if (factor > 1)
            {
                if (FactorBalance(nodo.Izquierdo) >= 0)
                    return RotarDerecha(nodo);
                else
                {
                    nodo.Izquierdo = RotarIzquierda(nodo.Izquierdo);
                    return RotarDerecha(nodo);
                }
            }
            if (factor < -1)
            {
                if (FactorBalance(nodo.Derecho) <= 0)
                    return RotarIzquierda(nodo);
                else
                {
                    nodo.Derecho = RotarDerecha(nodo.Derecho);
                    return RotarIzquierda(nodo);
                }
            }
            return nodo;
        }

        private NodoAVL RotarDerecha(NodoAVL y)
        {
            var x = y.Izquierdo;
            var T2 = x.Derecho;

            x.Derecho = y;
            y.Izquierdo = T2;

            y.Altura = Math.Max(Altura(y.Izquierdo), Altura(y.Derecho)) + 1;
            x.Altura = Math.Max(Altura(x.Izquierdo), Altura(x.Derecho)) + 1;

            return x;
        }

        private NodoAVL RotarIzquierda(NodoAVL x)
        {
            var y = x.Derecho;
            var T2 = y.Izquierdo;

            y.Izquierdo = x;
            x.Derecho = T2;

            x.Altura = Math.Max(Altura(x.Izquierdo), Altura(x.Derecho)) + 1;
            y.Altura = Math.Max(Altura(y.Izquierdo), Altura(y.Derecho)) + 1;

            return y;
        }
    }

    public class GrafoCombinaciones
    {
        private Dictionary<string, List<(string Pan, int Peso)>> adyacencias;

        public GrafoCombinaciones()
        {
            adyacencias = new Dictionary<string, List<(string, int)>>();
        }

        public void AgregarConexion(string pan1, string pan2, int peso)
        {
            if (!adyacencias.ContainsKey(pan1))
                adyacencias[pan1] = new List<(string, int)>();
            if (!adyacencias.ContainsKey(pan2))
                adyacencias[pan2] = new List<(string, int)>();

            adyacencias[pan1].Add((pan2, peso));
            adyacencias[pan2].Add((pan1, peso));
        }

        public List<string> ObtenerRecomendaciones(string panBase, int maxRecomendaciones = 3)
        {
            if (!adyacencias.ContainsKey(panBase)) return new List<string>();

            return adyacencias[panBase]
                .OrderByDescending(x => x.Peso)
                .Take(maxRecomendaciones)
                .Select(x => x.Pan)
                .ToList();
        }
    }
}
