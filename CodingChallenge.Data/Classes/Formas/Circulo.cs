using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Formas
{
    public class Circulo : FormaGeometrica
    {
        private decimal ladoRadio;
        
        public Circulo(decimal _ladoRadio)
        {
            this.IdTipo = 3;
            this.Nombre = "Circulo";
            ladoRadio = _ladoRadio;
        }

        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * (this.ladoRadio / 2) * (this.ladoRadio / 2);
        }
        public override decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * this.ladoRadio;
        }
    }
}
