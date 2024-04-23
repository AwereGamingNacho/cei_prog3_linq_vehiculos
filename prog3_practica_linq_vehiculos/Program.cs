using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using prog3_practica_linq_vehiculos;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>()
            {
                new Auto(1, "Volkswagen", "Mdl. 233", "Michelin", "Negro", 2005, 6),
                new Auto(2, "Ford", "Mdl. 1004", "Bridgestone", "Gris", 2002, 4),
                new Auto(3, "Cheverolet", "Mdl. 777", "Nexen", "Blanco", 2007, 5),
                new Moto(4, "Ford", "Mdl. 20", "Nexen", "Blanco", 2010, 250),
                new Moto(5, "Ford", "Mdl. 25", "Nexen", "Azul Oscuro", 2011, 500),
                new Moto(6, "Toyota", "Mdl. 3421", "Bridgestone", "Gris", 2009, 500),
                new Camion(7, "Honda", "Mdl. 10284", "Michelin", "Blanco", 2012, 20000),
                new Camion(8, "Honda", "Mdl. 11743", "Michelin", "Blanco", 2013, 25000),
                new Camion(9, "Ford", "Mdl. 10284", "Michelin", "Blanco", 2012, 22000),
            };

            vehiculosPorTipo<Auto>(vehiculos).ForEach(x => { Console.WriteLine(x.id + " " + x.ano); });
            vehiculosPorTipo<Moto>(vehiculos).ForEach(x => { Console.WriteLine(x.id + " " + x.ano); });
            vehiculosPorTipo<Camion>(vehiculos).ForEach(x => { Console.WriteLine(x.id + " " + x.ano); });

            cantidadPorTipo(vehiculos);


            Auto auto1 = new Auto(10, "Ford", "Mdl. 243124", "Nexon", "Rojo", 2009, 8);
            Moto moto1 = new Moto(11, "Toyota", "Mdl.9418203", "Nexon", "Negro", 2015, 150);
            Moto moto2 = new Moto(12, "Toyota", "Mdl. 435104", "Michelin", "Blanco", 2014, 250);

            vehiculos.Add(auto1);
            vehiculos.Add(moto1);
            vehiculos.Add(moto2);

            cantidadPorTipo(vehiculos);
        }

        static List<T> vehiculosPorTipo<T>(List<Vehiculo> vehiculos) where T : Vehiculo 
        {
            return vehiculos.OfType<T>().ToList();
        }
        static void cantidadPorTipo(List<Vehiculo> vehiculos)
        {
            Console.WriteLine("Cantidad de Autos: " + vehiculos.OfType<Auto>().ToList().Count);
            Console.WriteLine("Cantidad de Motos: " + vehiculos.OfType<Moto>().ToList().Count);
            Console.WriteLine("Cantidad de Camiones: " + vehiculos.OfType<Camion>().ToList().Count);
        }
    }
}