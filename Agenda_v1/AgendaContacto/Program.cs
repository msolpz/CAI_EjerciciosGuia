using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Agenda_v1.Dominio;
using Agenda_v1.Dominio.Entidades;


namespace Agenda_v1.ConsolaInterfaz
{
    public class Program
    {
        

        //es el punto de entrada a la app y el algoritmo que lo resuelve

        static void Main(string[] args)
        {
            

            try
            {
                Agenda a1 = new Agenda("Diario", "Electrónica", 5);
                bool consolaActiva = true;
                string opcionMenu;

                while (consolaActiva)
                {
                    do
                    {
                        DesplegarMenu();
                        opcionMenu = Console.ReadLine();
                        switch (opcionMenu)
                        {
                            case "1":
                                Listar(Agenda.agenda);
                                break;
                            case "2":
                                AgregarAgenda();
                                break;
                            case "3":
                            //EliminarContacto();
                            case "4":
                            //TraerContactoFrecuente;
                            case "5":
                                consolaActiva = false;
                                break;
                            default:
                                break;

                        }
                    } while (opcionMenu != "5");


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Se ha producido un error. Detalle: " + ex.Message);
            }
            finally
            {             
                Console.WriteLine("Presione una tecla para salir.");
                Console.ReadLine();
            }

        }

        public static void DesplegarMenu()
        {
            Console.WriteLine("Hola!");
            Console.WriteLine("Elija una opción (número): " + System.Environment.NewLine +
                "1- Listar Contactos de la agenda." + System.Environment.NewLine +
                "2- Agregar Contactos a la agenda." + System.Environment.NewLine +
                "3- Eliminar Contactos." + System.Environment.NewLine +
                "4- Traer Contacto Frecuente." + System.Environment.NewLine +
                "5- Salir.");
        }

        
        public static void AgregarContactos(Agenda agenda)
        {
            
            

            bool flag = false;
            //bool repetir = false;

            int codigo = agenda.CantidadRegistros() + 1;

               // do
               //{
                    string nombre;
                    string apellido;
                    string telefono;
                    string direccion;
                    string fecha;


                    do
                    {
                        Console.WriteLine("Cuál es tu nombre?");
                        nombre = Console.ReadLine();
                        flag = ValidarTexto(nombre);
                    } while (flag == false);

                    do
                    {
                        Console.WriteLine("Cuál es tu apellido?");
                        apellido = Console.ReadLine();
                        flag = ValidarTexto(apellido);
                    } while (flag == false);


                    int numero = 0;
                    bool flag2;
                    do
                    {
                        Console.WriteLine("Cuál es tu número de teléfono?");
                        telefono = Console.ReadLine();
                        flag2 = ValidarNumero(telefono, ref numero);
                    } while (flag2 == false);

                    do
                    {
                        Console.WriteLine("Dime tu dirección.");
                        direccion = Console.ReadLine();
                        flag = ValidarTexto(direccion);
                    } while (flag == false);

                    DateTime fechaNacimiento = DateTime.Now;
                    do
                    {
                        Console.WriteLine("Cuál es tu fecha de nacimiento?");
                        fecha = Console.ReadLine();
                        flag = ValidarFecha(fecha, ref fechaNacimiento);
                    } while (flag == false);



                    Contacto c = new Contacto(codigo, nombre, apellido, telefono, direccion, fechaNacimiento);
                    agenda.AgregarContacto(c);


                   // Console.WriteLine("Desea agregar otro contacto? Marque 1 para 'SI' u otra tecla para 'NO'.");
                   // string respuesta = Console.ReadLine();
                    //if (int.TryParse(respuesta, out int salida) && salida == 1)
                   // {
                   //     repetir = true;
                   // }
                   // else
                   // {
                   //     repetir = false;
                   // }

                //} while (repetir == true);


            
        }

        public static void AgregarAgenda()
        {
            bool check;
            string nombreAgenda;
            string tipo;
            int maximo = 0;

            do
            {
                Console.WriteLine("Ingrese el nombre de la agenda: ");
                nombreAgenda = Console.ReadLine();
                check = ValidarTexto(nombreAgenda);
            } while (check == false);

            do
            {
                check = false;
                Console.WriteLine("Ingrese el tipo de la agenda: ");
                tipo = Console.ReadLine();
                check = ValidarTexto(tipo);
            } while (check == false);

            do
            {
                check = false;
                Console.WriteLine("Ingrese el máximo de contactos de la agenda: ");
                string numero = Console.ReadLine();
                check = ValidarMaximo(numero, ref maximo);
            } while (check == false);

            Agenda agenda = new Agenda(nombreAgenda, tipo, maximo);

            bool repetir;
            do
            {
                Console.WriteLine("Desea agregar un contacto? Marque 1 para 'SI' u otra tecla para 'NO'.");
                string respuesta = Console.ReadLine();
                if (int.TryParse(respuesta, out int salida) && salida == 1)
                {
                    repetir = true;
                    AgregarContactos(agenda);
                }
                else
                {
                    repetir = false;
                }
            } while (repetir != false);

            

        }
        private static bool ValidarNumero(string numero, ref int salida)
        {
            bool flag = false;

            
            if (String.IsNullOrEmpty(numero) || String.IsNullOrWhiteSpace(numero))
            {
                Console.WriteLine("No ingresó números.");
            }
            else if (numero.Length >= 15)
            {
                Console.WriteLine("No ingresó un número válido.");
            }
            else if (!int.TryParse(numero, out salida))
            {
                Console.WriteLine("Usted debe ingresar un dato númerico.");
            }
            else
            {
                flag = true;
            }

            return flag;
        }

        private static bool ValidarTexto(string ingreso)
        {
            bool flag = false;

            if (int.TryParse(ingreso, out int salida))
            {
                Console.WriteLine("Usted NO debe ingresar un dato númerico.");
            }
            else if (String.IsNullOrEmpty(ingreso) || String.IsNullOrWhiteSpace(ingreso))
            {
                Console.WriteLine("No ingreso datos.");
            }
            else
            {
                flag = true;
            }

            return flag;
        }


        private static bool ValidarFecha(string fecha, ref DateTime salida)
        {
            bool flag = false;

            if (!DateTime.TryParse(fecha, out salida))
            {
                Console.WriteLine("El dato no es una fecha valida.");
            }
            else if (salida > DateTime.Now)
            {
                Console.WriteLine("La fecha no es correcta.");
            }
            else
            {
                flag = true;
            }

            return flag;
        }

        private static bool ValidarMaximo(string numero, ref int maximo)
        {
            bool flag = false;


            if (String.IsNullOrEmpty(numero) || String.IsNullOrWhiteSpace(numero))
            {
                Console.WriteLine("No ingresó números.");
            }
            else if (!int.TryParse(numero, out maximo))
            {
                Console.WriteLine("Usted debe ingresar un dato númerico.");
            }
            else if (Convert.ToInt32(numero) <= 0)
            {
                Console.WriteLine("No ingresó un número válido.");
            }
            else
            {
                flag = true;
            }

            return flag;
        }

        public static void Listar(Agenda agenda)
        {

            foreach (Contacto c in agenda.Contactos)
            {
                // Console.WriteLine(c.ToString());
                Console.WriteLine($"{c.Nombre} - {c.Apellido} - {c.Telefono}");
            }

        }

    
            
    }
}
