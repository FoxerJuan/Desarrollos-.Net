using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Formas
{
    public class Cuadrado : FormaGeometrica
    {
        private decimal lado;
        public Cuadrado(decimal _lado)
        {
            this.IdTipo = 1;
            this.Nombre = "Cuadrado";
            this.lado = _lado;
        }
        public override decimal CalcularArea()
        {
            return this.lado * this.lado;
        }
        public override decimal CalcularPerimetro()
        {
            return this.lado * 4;
        }
    }
}
