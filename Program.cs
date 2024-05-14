using System;

namespace Desafio1Boher
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario(1, "Mariel", "Boher", "marielboher", "miContraseña123", "mariel@mail.com");

            Producto producto = new Producto(101, "Laptop", 500.00, 800.00, 10, usuario.Id);

            Venta venta = new Venta(201, "Venta de laptop", usuario.Id);

            ProductoVendido productoVendido = new ProductoVendido(301, producto.Id, 1, venta.Id);

            Console.WriteLine($"Usuario: {usuario.Nombre} {usuario.Apellido}, Email: {usuario.Mail}");
            Console.WriteLine($"Producto: {producto.Descripcion}, Precio de Venta: ${producto.PrecioVenta}");
            Console.WriteLine($"Venta ID: {venta.Id}, Comentario: {venta.Comentarios}");
            Console.WriteLine($"Producto Vendido: ID Producto {productoVendido.IdProducto}, Cantidad: {productoVendido.Stock}");
        }
    }
}