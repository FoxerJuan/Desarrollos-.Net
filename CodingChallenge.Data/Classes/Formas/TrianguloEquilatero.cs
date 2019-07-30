using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Formas
{
    public class TrianguloEquilatero : FormaGeometrica
    {
        private decimal lado;
        public TrianguloEquilatero(decimal _lado)
        {
            this.IdTipo = 2;
            this.Nombre = "Triangulo Equilatero";
            this.lado = _lado;
        }
        public override decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * this.lado * this.lado;
        }
        public override decimal CalcularPerimetro()
        {
            return this.lado * 3;
        }
    }
}
