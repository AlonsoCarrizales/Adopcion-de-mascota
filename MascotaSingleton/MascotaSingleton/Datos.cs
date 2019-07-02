using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopcionesSingleton
{
    class Datos
    {
        // instancia de la memoria
        private static Datos instancia;
        public List<Perro> ListaPerros = new List<Perro> { };
        //public List<Persona> ListaPersonas = new List<Persona> { };
        // solo se generara objetos dentro de la clase
        private Datos()
        {

        }
        public static Datos GetInstancia()
        {
            if (instancia==null)
            {
                instancia = new Datos();
            }
            return instancia;
        }
    }
}
