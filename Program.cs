using Inventory;

Inventario inventario = new Inventario();

while (true)
{
    Console.WriteLine("\nComandos: agregar, mostrar, editar, eliminar, salir");
    Console.Write("Ingresa un comando: ");
    string comando = Console.ReadLine().ToLower();

    switch (comando)
    {
        case "agregar":
            Console.WriteLine("Nombre del producto: ");
            string nombre = Console.ReadLine();
            Console.Write("Cantidad: ");
            int cantidad = int.Parse(Console.ReadLine());
            Console.Write("Precio: ");
            decimal precio = decimal.Parse(Console.ReadLine());

            inventario.AgregarProducto(nombre, cantidad, precio);
            break;

        case "mostrar":
            inventario.MostrarProducto();
            break;

        case "eliminar":
            Console.Write("Ingrese el ID del producto a eliminar: ");
            int id = int.Parse(Console.ReadLine());
            inventario.EliminarProducto(id);
            break;

        case "editar":
            Console.Write("Ingrese el ID del producto a editar: ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Nuevo nombre: ");
            string nuevoNombre = Console.ReadLine();

            Console.Write("Nueva cantidad: ");
            int nuevaCantidad = int.Parse(Console.ReadLine());

            Console.Write("Nuevo precio: ");
            decimal nuevoPrecio = decimal.Parse(Console.ReadLine());

            inventario.EditarProducto(productId, nuevoNombre, nuevaCantidad, nuevoPrecio);
            break;

        case "salir":
            Console.WriteLine("Saliendo y guardando inventario.");
            return;

        default:
            Console.WriteLine("Comando no reconocido.");
            break;
    }
}