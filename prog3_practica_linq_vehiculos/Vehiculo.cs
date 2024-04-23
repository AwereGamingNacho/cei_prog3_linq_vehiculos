using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog3_practica_linq_vehiculos
{
    internal abstract class Vehiculo
    {
        public int id {  get; set; }
        public string marca { get; set; }
        public string modelo {  get; set; }
        public string ruedas { get; set; }
        public string color { get; set; }
        public int ano { get; set; }

        public Vehiculo(int id, string marca, string modelo, string ruedas, string color, int ano)
        {
            this.id = id;
            this.marca = marca;
            this.modelo = modelo;
            this.ruedas = ruedas;
            this.color = color;
            this.ano = ano;
        }
    }
}
