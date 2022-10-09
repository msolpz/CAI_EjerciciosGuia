using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_AgendaContacto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable para contener. La variable tiene un tipo
            Contacto c1 = new Contacto("Sergio", "Castro", "Av. Córdoba 1111", 01-05-1963, "+5491144444444");
            Contacto c2 = new Contacto("Marcela","Pérez","Av. Santa Fe 1331", 19-01-1968, "+5491133331111");
            Contacto c3 = new Contacto("Florencia","Quiteros","Av. Libertador 3467", 04-05-1999, "+5491155556666");
            Contacto c4 = new Contacto("Laura","López","Av. Corrientes 3000", 23-08-1974, "+5491155544444");
            Contacto c5 = new Contacto("Diego","Gimenez","Av. Alem 438", 28-10-1969, "+5491188888888");
            Contacto c6 = new Contacto("Tomás","Torres","Av. Independencia 3322", 12-12-2004, "+5491177772222");
            //con esto se generaron 6 instancias que tienen inicializado nombre, apellido, dirección y teléfono.

        }
    }
}
