using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrancoRepaso
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona UnaPersona = new Persona("José");

            Fabrica UnaAutomotriz = new Fabrica("Ford");

            Vehiculo UnAuto = new Vehiculo(UnaPersona, UnaAutomotriz, "2016");

            Console.Write(UnaAutomotriz.nombre);
            Console.Write(UnAuto.Dueño.nombre);

            UnAuto = "2017";

            Persona A = new Persona();
            Persona B = new Persona();

            B.nombre = "Jose";
            A.nombre = B.nombre;

            Persona C = new Persona();

            C = A;

            A.nombre = B.nombre;
            B.nombre = "Maria";

            Console.Write(C.nombre);


            Console.WriteLine("\n");
            //Listado vehiculo dentro de fabrica.
            Fabrica Fab = new Fabrica("Ford");
            Vehiculo Uno = new Vehiculo("2016");
            Vehiculo Dos = new Vehiculo("1990");

            Fab.Agregar(Uno);
            Fab.Agregar(Dos);
            Fab.Agregar(new Vehiculo("2000"));

            Uno.unAño = "1999";

            Fab.Mostrar();

            Console.WriteLine("\n");

            Vehiculo Tres = new Vehiculo("1980");
            Uno = Dos;
            Dos.unAño = "1970";
            Uno = Tres;
            Tres.unAño = "1950";
            Uno.unAño = "1900";

            Tres = Uno;

            Fab.Mostrar();

            Console.ReadKey();
        }
    }
}
