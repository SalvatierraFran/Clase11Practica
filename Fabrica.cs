using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrancoRepaso
{
    class Fabrica
    {
        public string nombre;
        public List<Vehiculo> ListaDeAutos;

        public Fabrica(string FabricaNombre)
        {
            this.nombre = FabricaNombre;

            this.ListaDeAutos = new List<Vehiculo>();
        }

        public void Agregar(Vehiculo UnVehiculo)
        {
            this.ListaDeAutos.Add(UnVehiculo);
        }

        public void Mostrar()
        {
            foreach (Vehiculo Autorrecorriendo in this.ListaDeAutos)
            {
                Console.WriteLine(Autorrecorriendo.unAño);
            }
        }
    }
}
