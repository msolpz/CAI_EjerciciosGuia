using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PruebasPractica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cómo te llamas?");
            string nombre = Console.ReadLine();


            bool EsCorrecto(string variable)
            {
                if (nombre.Substring(0, 1).ToUpper() != "A")
                    // es lo mismo decir: (nombre.Substring(0, 1) != "A" || nombre.Substring(0, 1) != "a")
                    // ToUpper() sirve para chequear que si se puso una a minuscula no pase desapercibido 
                    // ToLower() para cuando verificamos que no sea "a" para que la mayuscula no pase desapercibida
                    return true;
                else
                    return false;
                // return (nombre.Substring(0,1) != "A"); //Decir esto es lo mismo que lo de arriba
            }


            bool _esCorrecto = EsCorrecto(nombre);

            if (_esCorrecto)
                Console.WriteLine("Tu nombre NO empieza con A");
            else
                Console.WriteLine("Tu nombre empieza con A");

            Thread.Sleep(2500);
        }
    }
}
