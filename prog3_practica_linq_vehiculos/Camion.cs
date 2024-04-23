using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog3_practica_linq_vehiculos
{
    internal class Camion : Vehiculo
    {
        public int toneladas {  get; set; }

        public Camion(int id, string marca, string modelo, string ruedas, string color, int ano, int toneladas): base (id, marca, modelo, ruedas, color, ano)
        {
            this.toneladas = toneladas;
        }
    }
}
