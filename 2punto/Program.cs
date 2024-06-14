using System;

public interface IVehiculo
{
    void MostrarDetalles();
}

//Bueno cramos las clases Vehiculo y Singleton
public class Bus : IVehiculo
{
    private static Bus _instancia;

    //instancias fuera de la clase
    private Bus() { }

  // otra instancia
    public static Bus Instancia
    {
        get
        {
            if (_instancia == null)
            {
                _instancia = new Bus();
            }
            return _instancia;
        }
    }

    public void MostrarDetalles()
    {
        Console.WriteLine("Soy un bus.");
    }
}

// Otra clase concreta que implementa Vehiculo y Singleton
public class Taxi : IVehiculo
{
    private static Taxi _instancia;

  
    private Taxi() { }

    public static Taxi Instancia
    {
        get
        {
            if (_instancia == null)
            {
                _instancia = new Taxi();
            }
            return _instancia;
        }
    }

    public void MostrarDetalles()
    {
        Console.WriteLine("Soy un taxi.");
    }
}

// Clase Factory 
public static class VehiculoFactory
{
    public static IVehiculo CrearVehiculo(string tipo)
    {
        switch (tipo.ToLower())
        {
            case "bus":
                return Bus.Instancia;
            case "taxi":
                return Taxi.Instancia;
            default:
                throw new ArgumentException("Tipo de vehículo desconocido.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear instancias de vehículos usando la Factory
        IVehiculo bus1 = VehiculoFactory.CrearVehiculo("bus");
        IVehiculo bus2 = VehiculoFactory.CrearVehiculo("bus");

        IVehiculo taxi1 = VehiculoFactory.CrearVehiculo("taxi");
        IVehiculo taxi2 = VehiculoFactory.CrearVehiculo("taxi");

        
        bus1.MostrarDetalles();
        bus2.MostrarDetalles();
        taxi1.MostrarDetalles();
        taxi2.MostrarDetalles();

        Console.WriteLine("¿Bus1 y Bus2 son la misma instancia? " + (bus1 == bus2));
        Console.WriteLine("¿Taxi1 y Taxi2 son la misma instancia? " + (taxi1 == taxi2));
    }
}
