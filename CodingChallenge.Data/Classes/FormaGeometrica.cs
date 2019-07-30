using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public abstract class FormaGeometrica
    {
        private int idTipo;
        private string nombre;
        
        /*setters y getters */
        public int IdTipo
        {
            set { idTipo = value; }
            get { return idTipo; }
        }
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        /*----*/

        public abstract decimal CalcularArea();
        public abstract decimal CalcularPerimetro();
    }
}
