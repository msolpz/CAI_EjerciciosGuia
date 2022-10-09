using Agenda_v1.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agenda_v1.Dominio.Excepciones;

namespace Agenda_v1.Dominio
{
    public class Agenda
    {
        private string _nombre;
        private string _tipo;
        private int _cantidadMaximaContactos;
        private List<Contacto> _contactos;

        public string Nombre
        {
            get
            {
                return _nombre;
            }
        }
        public string Tipo
        {
            get
            {
                return _tipo;
            }
        }
        public int CantidadRegistros()
        {
            return _contactos.Count;
        }
        public int CantidadMaxRegistros => _cantidadMaximaContactos;

        public Agenda(string nombre, string tipo, int maximo)
        {
            _nombre = nombre;
            _tipo = tipo;
            _cantidadMaximaContactos = maximo;
            _contactos = new List<Contacto>();
        }
        public void AgregarContacto(Contacto c)
        {

            if (CantidadRegistros() < _cantidadMaximaContactos)
            {

                _contactos.Add(c);
            }
            else
            {
                throw new Excepciones.AgendaCompletaEx.AgendaCompletaException();
            }
        }
        public void EliminarContacto(int codigo) { }
        public Contacto TraerContactoFrecuente() { return null; }


    }
}
