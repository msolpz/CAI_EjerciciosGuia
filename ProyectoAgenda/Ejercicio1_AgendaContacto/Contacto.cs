using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_AgendaContacto
{
    public class Contacto //se pone public para poder instanciarla
    {
        //constructor: punto de acceso por donde se crea la instancia, donde se inicializa este objeto
        //firma del constructor (no tiene tipo de devolución como el método): 'tipo de visibilidad' + 'nombre' + ()
        public Contacto(string nombre, string apellido, string direccion, int fecha, string telefono)
        {
            _nombre = nombre;
            _apellido = apellido;
            _direccion = direccion;
            _fechaNacimiento = Convert.ToDateTime(fecha);
            _telefono = telefono;
            _llamadas = 0;
        }//no todos los atributos de la clase pueden estar en el constructor. 
        //Se define en función del negocio qué se recibe por única vez y cuales inicializamos o trabajamos dentro de la clase.


        //atributos de clase / variable de clase
        //va a ser private o protegida
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private DateTime _fechaNacimiento; 
        private string _telefono; //como string ocupa + en memoria que un int pero se usa para permitir poner '+54'
        private int _llamadas;

        //propiedades: atributos encapsulados: determinar cual va a ser el acceso que le voy a dar a mis atributos.
        //Limito los detalles de la implementación
        public string Nombre
        {
            get
            {
                return _nombre;
            } //sin el set es una propiedad de readonly
            set
            {
                _nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return _apellido;
            } 
            set
            {
                _apellido = value;
            }
        }

        public string Direccion
        {
            get
            {
                return _direccion;
            } 
            set
            {
                _direccion = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return _fechaNacimiento;
            }
            set
            {
                _fechaNacimiento = value;
            }
        }

        public string Telefono
        {
            get
            {
                return _telefono;
            } 
            set
            {
                _telefono = value;
            }
        }
        public int Llamadas
        {
            get //sin el set es una propiedad de readonly
            {
                return _llamadas;
            } 
            
        }


        // métodos - acciones, 2 tipos: función (devuelve algo) o subrutina (no devuelve nada) 
        // firma del método (cómo se desarrollan): 'tipo de visibilidad' + 'tipo de dato' + 'nombre' + ('parámetros') 
        public int Edad()
        {
            //implementación
            return 0;
        }
    }
}
