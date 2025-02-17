
using Newtonsoft.Json;

namespace Inventory
{
    public class Inventario
    {
        private List<Producto> productos;
        private string archivo = "inventario.json";
        private int ultimoId;

        public Inventario()
        {
            productos = new List<Producto>();
            ultimoId = productos.Count > 0 ? productos[^1].Id : 0;
            CargarInventario();
        }

        public void AgregarProducto(string nombre, int cantidad, decimal precio)
        {
            int nuevoId = ++ultimoId;
            productos.Add(new Producto(nuevoId, nombre, cantidad, precio));
            var json = JsonConvert.SerializeObject(productos, Formatting.Indented);
            File.WriteAllText(archivo, json);
            Console.WriteLine("Producto agregado.");
        }

        public void MostrarProducto()
        {
            Console.WriteLine("\n Productos en inventario:");
            if (productos.Count == 0)
            {
                Console.WriteLine("No hay productos en el inventario.");
            }
            else
            {
                foreach (var p in productos)
                {
                    Console.WriteLine($"[{p.Id}] {p.Nombre} - {p.Cantidad} unidades, ${p.Precio}");
                }
            }
        }

        public void EliminarProducto(int id)
        {
            var producto = productos.Find(p => p.Id == id);
            if (producto != null)
            {
                productos.Remove(producto);
                var json = JsonConvert.SerializeObject(productos, Formatting.Indented);
                File.WriteAllText(archivo, json);
                Console.WriteLine($"Producto con Id {id} eliminado.");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }
        public void EditarProducto(int id, string nombre, int cantidad, decimal precio)
        {
            var producto = productos.Find(p => p.Id == id);
            if (producto != null)
            {
                producto.Nombre = nombre;
                producto.Cantidad = cantidad;
                producto.Precio = precio;

                var json = JsonConvert.SerializeObject(productos, Formatting.Indented);
                File.WriteAllText(archivo, json);
                Console.WriteLine($"✅ Producto con ID {id} actualizado.");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }

        public void CargarInventario()
        {
            if (File.Exists(archivo))
            {
                var json = File.ReadAllText(archivo);
                productos = JsonConvert.DeserializeObject<List<Producto>>(json) ?? new List<Producto>();
                Console.WriteLine("Inventario cargado.");
            }
        }
    }
}