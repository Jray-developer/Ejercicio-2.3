using System;

class Program
{
    static void Main()
    {
        Motocicleta moto = new Motocicleta("Yamaha", "MT-09", 890);
        Camion camion = new Camion("Volvo", "FH16", 25);

        moto.MostrarInfo();
        camion.MostrarInfo();

        Console.WriteLine();

        Gerente gerente = new Gerente("Ana López", "Gerente de Ventas", "MBA", 12);
        Programador programador = new Programador("Carlos Pérez", "Desarrollador Senior", "AWS Certified", "C#");

        gerente.MostrarInfo();
        programador.MostrarInfo();
    }
}

class Vehiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }

    public Vehiculo(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }

    public virtual void MostrarInfo()
    {
        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}");
    }
}

class Motocicleta : Vehiculo
{
    public int Cilindraje { get; set; }

    public Motocicleta(string marca, string modelo, int cilindraje)
        : base(marca, modelo)
    {
        Cilindraje = cilindraje;
    }

    public override void MostrarInfo()
    {
        Console.WriteLine($"Motocicleta -> Marca: {Marca}, Modelo: {Modelo}, Cilindraje: {Cilindraje} cc");
    }
}

class Camion : Vehiculo
{
    public double CapacidadCarga { get; set; } 

    public Camion(string marca, string modelo, double capacidadCarga)
        : base(marca, modelo)
    {
        CapacidadCarga = capacidadCarga;
    }

    public override void MostrarInfo()
    {
        Console.WriteLine($"Camión -> Marca: {Marca}, Modelo: {Modelo}, Capacidad de Carga: {CapacidadCarga} toneladas");
    }
}
class Empleado
{
    public string Nombre { get; set; }
    public string Puesto { get; set; }
    public string Certificaciones { get; set; }

    public Empleado(string nombre, string puesto, string certificaciones)
    {
        Nombre = nombre;
        Puesto = puesto;
        Certificaciones = certificaciones;
    }

    public virtual void MostrarInfo()
    {
        Console.WriteLine($"Nombre: {Nombre}, Puesto: {Puesto}, Certificaciones: {Certificaciones}");
    }
}

class Gerente : Empleado
{
    public int NumeroEmpleadosACargo { get; set; }

    public Gerente(string nombre, string puesto, string certificaciones, int numeroEmpleados)
        : base(nombre, puesto, certificaciones)
    {
        NumeroEmpleadosACargo = numeroEmpleados;
    }

    public override void MostrarInfo()
    {
        Console.WriteLine($"Gerente -> Nombre: {Nombre}, Puesto: {Puesto}, Certificaciones: {Certificaciones}, Empleados a Cargo: {NumeroEmpleadosACargo}");
    }
}

class Programador : Empleado
{
    public string LenguajePrincipal { get; set; }

    public Programador(string nombre, string puesto, string certificaciones, string lenguaje)
        : base(nombre, puesto, certificaciones)
    {
        LenguajePrincipal = lenguaje;
    }

    public override void MostrarInfo()
    {
        Console.WriteLine($"Programador -> Nombre: {Nombre}, Puesto: {Puesto}, Certificaciones: {Certificaciones}, Lenguaje Principal: {LenguajePrincipal}");
    }
}
