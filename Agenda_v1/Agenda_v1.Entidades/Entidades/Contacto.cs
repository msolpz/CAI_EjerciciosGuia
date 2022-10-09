using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_v1.Dominio.Entidades
{
    public class Contacto 
    {
        //atributos o variables de clase
        private int _codigo = 0;
        private string _nombre;
        private string _apellido;
        private string _telefono;
        private string _direccion;
        private DateTime _fechaNacimiento;
        private int _llamadas = 0;

        //propiedades

        public int Codigo
        {
            get
            {
                return _codigo; // Sin el set es de Read-only
            }
        }
        public string Nombre
        {
            get
            {
                return _nombre; //devuelve el valor que tiene nombre
            }
            set
            {
                _nombre = value; //Hace que la variable sea de escritura. Read-Write
            }
        }

        public string Apellido
        {
            get
            {
                return _apellido;
            }
        }

        public string Telefono
        {
            get
            {
                return _telefono;
            }
        }
        public string Direccion
        {
            get
            {
                return _direccion;
            }
        }
        public int Llamadas
        {
            get
            {
                return _llamadas; // Sin el set es de Read-only
            }
        }
        public DateTime FechaNacimiento
        {
            get
            {
                return _fechaNacimiento;
            }
        }

        //constructor -> para inicializar el objeto de una
        public Contacto(int codigo, string nombre, string apellido, string telefono, string direccion, DateTime fechaNacimiento)
        {
            _codigo = codigo;
            _nombre = nombre;
            _apellido = apellido;
            _telefono = telefono;
            _direccion = direccion;
            _fechaNacimiento = fechaNacimiento;

        }


        //métodos
        public int Edad()
        {
            //implementación
            double edad = (DateTime.Now - _fechaNacimiento).Days / 365;
            return Convert.ToInt32(edad);
        }

        public void Llamar()
        {
            _llamadas++;
        }




    }
}
