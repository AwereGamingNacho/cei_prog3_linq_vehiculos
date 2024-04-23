using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog3_practica_linq_vehiculos
{
    internal class Auto : Vehiculo
    {
        public int cantidadPasajeros {  get; set; }

        public Auto(int id, string marca, string modelo, string ruedas, string color, int ano, int cantidadPasajeros): base(id,marca,modelo,ruedas, color, ano)
        {
            this.cantidadPasajeros = cantidadPasajeros;
        }
    }
}
