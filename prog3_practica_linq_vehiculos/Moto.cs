using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog3_practica_linq_vehiculos
{
    internal class Moto : Vehiculo
    {
        public int cilindrdas {  get; set; }

        public Moto(int id, string marca, string modelo, string ruedas, string color, int ano, int cilindrdas): base(id, marca, modelo, ruedas, color, ano)
        {
            this.cilindrdas = cilindrdas;
        }
    }
}
