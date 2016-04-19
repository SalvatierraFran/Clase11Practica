using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrancoRepaso
{
    class Vehiculo
    {
        public Persona Dueño;
        public Fabrica UnaAutomotriz;
        public string unAño;
        //public string anio;

        public Vehiculo()
        { }

        static Vehiculo()
        { }

        public Vehiculo(string año)
        {
            this.unAño = año;
        }

        public Vehiculo(Persona Personita, Fabrica Automotriz, string año)
        {
            this.Dueño = Personita;
            this.UnaAutomotriz = Automotriz;
            this.unAño = año;
        }

        public static implicit operator Vehiculo(string año)
        {
            return new Vehiculo(año);
        }
    }
}
