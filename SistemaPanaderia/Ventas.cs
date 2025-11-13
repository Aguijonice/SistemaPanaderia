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
    public partial class Ventas : Form
    {
        private InventarioHash inventario;
        private CarritoCompra carrito;
        public Ventas()
        {
            InitializeComponent();


            inventario = new InventarioHash();
            carrito = new CarritoCompra();
            CargarInventarioInicial();
            CargarComboboxPanes();
            ActualizarTotales();
        }

        private void CargarInventarioInicial()
        {
            inventario.ActualizarProducto("Nuevo pan de chocolate", 50, 25.00m);
            inventario.ActualizarProducto("Concha", 30, 12.50m);
            inventario.ActualizarProducto("Quesadilla", 25, 18.00m);
            inventario.ActualizarProducto("Peperecha", 40, 15.75m);
            inventario.ActualizarProducto("Simita alta", 35, 10.00m);
            inventario.ActualizarProducto("Salpor", 20, 22.50m);
            inventario.ActualizarProducto("Poleada", 15, 16.80m);
        }

        private void CargarComboboxPanes()
        {
            List<string> panes = inventario.ObtenerProductos();
            cmpan1.Items.Clear();
            cmpan2.Items.Clear();
            cmpan3.Items.Clear();
            cmpan1.Items.AddRange(panes.ToArray());
            cmpan2.Items.AddRange(panes.ToArray());
            cmpan3.Items.AddRange(panes.ToArray());
        }

        private void AgregarAlCarrito()
        {
            if (string.IsNullOrWhiteSpace(txtNombreCliente.Text))
            {
                MessageBox.Show("❌ Por favor ingresa el nombre del cliente.", "Dato Requerido",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int cantidad = (int)CantidadPan.Value;
            if (cantidad <= 0)
            {
                MessageBox.Show("❌ La cantidad debe ser mayor a 0.", "Cantidad Inválida",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> panesSeleccionados = new List<string>();
            if (cmpan1.SelectedItem != null) panesSeleccionados.Add(cmpan1.SelectedItem.ToString());
            if (cmpan2.SelectedItem != null) panesSeleccionados.Add(cmpan2.SelectedItem.ToString());
            if (cmpan3.SelectedItem != null) panesSeleccionados.Add(cmpan3.SelectedItem.ToString());

            if (panesSeleccionados.Count == 0)
            {
                MessageBox.Show("❌ Por favor selecciona al menos un pan.", "Selección Requerida",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool algunProductoAgregado = false;
            string productosSinStock = "";

            foreach (string pan in panesSeleccionados)
            {
                if (inventario.VerificarStock(pan, cantidad))
                {
                    decimal precio = inventario.ObtenerPrecio(pan);
                    carrito.AgregarProducto(pan, precio, cantidad);
                    algunProductoAgregado = true;
                }
                else
                {
                    productosSinStock += $"\n• {pan} (Stock: {inventario.ObtenerStock(pan)})";
                }
            }

            if (algunProductoAgregado)
            {
                ActualizarTotales();
                if (!string.IsNullOrEmpty(productosSinStock))
                {
                    MessageBox.Show($"✅ Productos agregados.\n\n⚠️  Sin stock:{productosSinStock}",
                                  "Resultado Parcial", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"✅ Todos los productos agregados.", "Éxito",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show($"❌ No se pudo agregar ningún producto.{productosSinStock}",
                              "Sin Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ActualizarTotales()
        {
            decimal subtotal = carrito.CalcularSubtotal();
            decimal iva = carrito.CalcularIVA(subtotal);
            decimal total = carrito.CalcularTotal(subtotal, iva);
            lbSubtotal.Text = $"$ {subtotal:F2}";
            lbventas.Text = $"$ {iva:F2}";
            lbTotal.Text = $"$ {total:F2}";
        }

        private void LimpiarFormulario()
        {
            txtNombreCliente.Clear();
            CantidadPan.Value = 1;
            cmpan1.SelectedIndex = -1;
            cmpan2.SelectedIndex = -1;
            cmpan3.SelectedIndex = -1;
            carrito.LimpiarCarrito();
            ActualizarTotales();
            MessageBox.Show("🧹 Formulario limpiado.", "Nueva Venta",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FinalizarVenta()
        {
            if (string.IsNullOrWhiteSpace(txtNombreCliente.Text))
            {
                MessageBox.Show("❌ Ingresa el nombre del cliente.", "Dato Requerido",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (carrito.EstaVacio())
            {
                MessageBox.Show("❌ No hay productos en el carrito.", "Carrito Vacío",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal subtotal = carrito.CalcularSubtotal();
            decimal iva = carrito.CalcularIVA(subtotal);
            decimal total = carrito.CalcularTotal(subtotal, iva);

            string resumenProductos = "";
            var items = carrito.ObtenerItems();
            foreach (var item in items)
            {
                resumenProductos += $"\n• {item.Key} x{item.Value.Cantidad} = ${item.Value.Cantidad * item.Value.Precio:F2}";
            }

            string mensaje = $"🧾 RESUMEN DE VENTA\n\n" +
                           $"👤 Cliente: {txtNombreCliente.Text}\n\n" +
                           $"📦 Productos:{resumenProductos}\n\n" +
                           $"💰 Subtotal: ${subtotal:F2}\n" +
                           $"📊 IVA (13%): ${iva:F2}\n" +
                           $"💵 Total: ${total:F2}\n\n" +
                           $"¿Confirmar venta?";

            DialogResult resultado = MessageBox.Show(mensaje, "✅ CONFIRMAR VENTA",
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                foreach (var item in items)
                {
                    inventario.ReducirStock(item.Key, item.Value.Cantidad);
                }

                MessageBox.Show($"🎉 VENTA EXITOSA!\nTotal: ${total:F2}",
                              "✅ VENTA COMPLETADA",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
        }



        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lbSubtotal_Click(object sender, EventArgs e)
        {

        }

        private void Ventas_Load(object sender, EventArgs e)
        {

        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btFFinalizarVenta_Click(object sender, EventArgs e)
        {
            FinalizarVenta();
        }

        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            AgregarAlCarrito();
        }

        private void CantidadPan_ValueChanged(object sender, EventArgs e)
        {
            if (!carrito.EstaVacio())
            {
                ActualizarTotales();
            }
        }

        private void cmpan1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!carrito.EstaVacio())
            {
                ActualizarTotales();
            }
        }

        private void cmpan2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!carrito.EstaVacio())
            {
                ActualizarTotales();
            }
        }

        private void cmpan3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!carrito.EstaVacio())
            {
                ActualizarTotales();
            }
        }
        public class InventarioHash
        {
            private Dictionary<string, int> stockHash;
            private Dictionary<string, decimal> preciosHash;

            public InventarioHash()
            {
                stockHash = new Dictionary<string, int>();
                preciosHash = new Dictionary<string, decimal>();
            }

            public void ActualizarProducto(string producto, int stock, decimal precio)
            {
                if (stockHash.ContainsKey(producto))
                {
                    stockHash[producto] = stock;
                    preciosHash[producto] = precio;
                }
                else
                {
                    stockHash.Add(producto, stock);
                    preciosHash.Add(producto, precio);
                }
            }
            public bool VerificarStock(string producto, int cantidadRequerida = 1)
            {
                return stockHash.ContainsKey(producto) && stockHash[producto] >= cantidadRequerida;
            }

            public decimal ObtenerPrecio(string producto)
            {
                return preciosHash.ContainsKey(producto) ? preciosHash[producto] : 0;
            }

            public int ObtenerStock(string producto)
            {
                return stockHash.ContainsKey(producto) ? stockHash[producto] : 0;
            }

            public void ReducirStock(string producto, int cantidad = 1)
            {
                if (stockHash.ContainsKey(producto))
                {
                    stockHash[producto] -= cantidad;
                    if (stockHash[producto] < 0) stockHash[producto] = 0;
                }
            }
            public List<string> ObtenerProductos()
            {
                return stockHash.Keys.ToList();
            }
        }
        public class CarritoCompra
        {
            private Dictionary<string, (int Cantidad, decimal Precio)> items;

            public CarritoCompra()
            {
                items = new Dictionary<string, (int, decimal)>();
            }

            public void AgregarProducto(string producto, decimal precio, int cantidad = 1)
            {
                if (items.ContainsKey(producto))
                {
                    var item = items[producto];
                    items[producto] = (item.Cantidad + cantidad, precio);
                }
                else
                {
                    items[producto] = (cantidad, precio);
                }
            }

            public decimal CalcularSubtotal()
            {
                return items.Sum(item => item.Value.Cantidad * item.Value.Precio);
            }

            public decimal CalcularIVA(decimal subtotal)
            {
                return subtotal * 0.13m;
            }

            public decimal CalcularTotal(decimal subtotal, decimal iva)
            {
                return subtotal + iva;
            }

            public Dictionary<string, (int Cantidad, decimal Precio)> ObtenerItems()
            {
                return new Dictionary<string, (int, decimal)>(items);
            }

            public void LimpiarCarrito()
            {
                items.Clear();
            }

            public bool EstaVacio()
            {
                return items.Count == 0;
            }
        }
    }
}

        

