using System;
using System.Collections.Generic;
using System.Linq;

class Producto
{
    public string Nombre { get; set; }
    public string Categoria { get; set; }
    public decimal Precio { get; set; }
    public int Cantidad { get; set; }
}

class Program
{
    static List<Producto> productos = new List<Producto>();

    static void Main()
    {
        string opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("Menu");
            Console.WriteLine("1. Registrar producto");
            Console.WriteLine("2. Consultar productos");
            Console.WriteLine("3. Actualizar productos");
            Console.WriteLine("4. Eliminar producto");
            Console.WriteLine("5. Mostrar estadísticas");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1": RegistrarProducto(); break;
                case "2": ConsultarProducto(); break;
                case "3": ActualizarProducto(); break;
                case "4": EliminarProducto(); break;
                case "5": MostrarEstadisticas(); break;
                default: Console.WriteLine("Opción no válida."); break;
            }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        } while (opcion != "6");
    }

    static void RegistrarProducto()
    {
        Console.WriteLine("\n=== REGISTRAR PRODUCTO ===");
        Producto p = new Producto();
        Console.Write("Nombre: ");
        p.Nombre = Console.ReadLine();
        Console.Write("Categoría: ");
        p.Categoria = Console.ReadLine();
        Console.Write("Precio: ");
        p.Precio = decimal.Parse(Console.ReadLine());
        Console.Write("Cantidad: ");
        p.Cantidad = int.Parse(Console.ReadLine());
        productos.Add(p);
        Console.WriteLine("Producto registrado con éxito.");
    }

    static void ConsultarProducto()
    {
        Console.WriteLine("\n=== CONSULTAR PRODUCTO ===");
        Console.WriteLine("Buscar por: 1) Nombre  2) Categoría");
        string tipo = Console.ReadLine();
        Console.Write("Ingrese el dato a buscar: ");
        string dato = Console.ReadLine().ToLower();

        var resultado = (tipo == "1")
            ? productos.Where(p => p.Nombre.ToLower().Contains(dato))
            : productos.Where(p => p.Categoria.ToLower().Contains(dato));

        if (resultado.Any())
        {
            foreach (var p in resultado)
                Console.WriteLine($"- {p.Nombre} | Cat: {p.Categoria} | Precio: {p.Precio:C} | Cant: {p.Cantidad}");
        }
        else Console.WriteLine("No se encontraron productos.");
    }

    static void ActualizarProducto()
    {
        Console.WriteLine("\n=== ACTUALIZAR PRODUCTO ===");
        Console.Write("Ingrese el nombre del producto: ");
        string nombre = Console.ReadLine().ToLower();

        var producto = productos.FirstOrDefault(p => p.Nombre.ToLower() == nombre);
        if (producto != null)
        {
            Console.Write($"Nuevo precio (actual: {producto.Precio}): ");
            producto.Precio = decimal.Parse(Console.ReadLine());
            Console.Write($"Nueva cantidad (actual: {producto.Cantidad}): ");
            producto.Cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine("Producto actualizado.");
        }
        else Console.WriteLine("Producto no encontrado.");
    }

    static void EliminarProducto()
    {
        Console.WriteLine("\n=== ELIMINAR PRODUCTO ===");
        Console.Write("Ingrese el nombre del producto: ");
        string nombre = Console.ReadLine().ToLower();

        var producto = productos.FirstOrDefault(p => p.Nombre.ToLower() == nombre);
        if (producto != null)
        {
            productos.Remove(producto);
            Console.WriteLine("Producto eliminado.");
        }
        else Console.WriteLine("Producto no encontrado.");
    }

    static void MostrarEstadisticas()
    {
        Console.WriteLine("Inventario");

        decimal precioPromedio = productos.Average(p => p.Precio);
        int totalStock = productos.Sum(p => p.Cantidad);
        var masCaro = productos.OrderByDescending(p => p.Precio).First();
        var masBarato = productos.OrderBy(p => p.Precio).First();

        Console.WriteLine($"Precio promedio: {precioPromedio:C}");
        Console.WriteLine($"Total de stock: {totalStock}");
        Console.WriteLine($"Producto más caro: {masCaro.Nombre} ({masCaro.Precio:C})");
        Console.WriteLine($"Producto más barato: {masBarato.Nombre} ({masBarato.Precio:C})");
    }
}
