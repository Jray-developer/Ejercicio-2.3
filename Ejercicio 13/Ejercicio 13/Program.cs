/*
using System;

interface IPago
{
    void ProcesarPago(double monto);
}

class PagoTarjeta : IPago
{
    public void ProcesarPago(double monto)
    {
        Console.WriteLine($"Procesando pago con tarjeta por ${monto}");
    }
}

class PagoEfectivo : IPago
{
    public void ProcesarPago(double monto)
    {
        Console.WriteLine($"Pago en efectivo recibido: ${monto}");
    }
}

class PagoPayPal : IPago
{
    public void ProcesarPago(double monto)
    {
        Console.WriteLine($"Pago realizado mediante PayPal por ${monto}");
    }
}

class SistemaPagos
{
    private IPago metodoPago;

    public SistemaPagos(IPago metodo)
    {
        metodoPago = metodo;
    }

    public void RealizarPago(double monto)
    {
        metodoPago.ProcesarPago(monto);
    }
}

class Program
{
    static void Main()
    {
        SistemaPagos pago1 = new SistemaPagos(new PagoTarjeta());
        pago1.RealizarPago(165);

        SistemaPagos pago2 = new SistemaPagos(new PagoEfectivo());
        pago2.RealizarPago(800);

        SistemaPagos pago3 = new SistemaPagos(new PagoPayPal());
        pago3.RealizarPago(82.75);
    }
}
*/
/*
using System;

interface IImprimible
{
    void Imprimir();
}

class Factura : IImprimible
{
    public void Imprimir()
    {
        Console.WriteLine("Imprimiendo factura con detalle de compra...");
    }
}

class Reporte : IImprimible
{
    public void Imprimir()
    {
        Console.WriteLine("Imprimiendo reporte mensual de ventas...");
    }
}

class Etiqueta : IImprimible
{
    public void Imprimir()
    {
        Console.WriteLine("Imprimiendo etiqueta de producto...");
    }
}

class ProgramaImpresion
{
    static void Main()
    {
        IImprimible[] documentos = { new Factura(), new Reporte(), new Etiqueta() };

        foreach (var doc in documentos)
        {
            doc.Imprimir();
        }
    }
}
*/
using System;

interface IAutenticable
{
    bool Autenticar(string usuario, string contraseña);
}

class UsuarioWeb : IAutenticable
{
    public bool Autenticar(string usuario, string contraseña)
    {
        return usuario == "cliente" && contraseña == "1234";
    }
}

class Administrador : IAutenticable
{
    public bool Autenticar(string usuario, string contraseña)
    {
        return usuario == "admin" && contraseña == "root";
    }
}

class Invitado : IAutenticable
{
    public bool Autenticar(string usuario, string contraseña)
    {
        Console.WriteLine("Acceso limitado como invitado, sin necesidad de contraseña.");
        return true;
    }
}

class SistemaLogin
{
    static void Main()
    {
        IAutenticable usuario1 = new UsuarioWeb();
        IAutenticable admin = new Administrador();
        IAutenticable invitado = new Invitado();

        Console.WriteLine(usuario1.Autenticar("cliente", "1234") ? "Login de usuario exitoso" : "Error en login de usuario");
        Console.WriteLine(admin.Autenticar("admin", "root") ? "Login de administrador exitoso" : "Error en login de administrador");
        invitado.Autenticar("", "");
    }
}
