using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Formas
{
    public class Trapecio : FormaGeometrica
    {
        private decimal ladoBaseMayor;
        private decimal ladoBaseMenor;
        private decimal ladoC;
        private decimal ladoD;
        public Trapecio(decimal _ladoBaseMayor, decimal _ladoBaseMenor, decimal _ladoC, decimal _ladoD)
        {
            this.IdTipo = 4;
            this.Nombre = "Trapecio";
            this.ladoBaseMayor = _ladoBaseMayor;
            this.ladoBaseMenor = _ladoBaseMenor;
            this.ladoC = _ladoC;
            this.ladoD = _ladoD;
        }
        public override decimal CalcularArea()
        {
            double a = (double)this.ladoBaseMayor;
            double b = (double)this.ladoBaseMenor;
            double c = (double)this.ladoC;
            double d = (double)this.ladoD;
            double aux = (Math.Pow(c, 2) - Math.Pow(d, 2) + Math.Pow((a - b), 2)) / (2 * (a - b));
            double total = (a + b) / 2 * Math.Sqrt(Math.Pow(c, 2) - Math.Pow(aux, 2));
            return (decimal)total;
            //double total = (a + b) / 2 * Math.Sqrt(Math.Pow(c, 2) - Math.Pow(aux, 2));
        }
        public override decimal CalcularPerimetro()
        {
            return ladoBaseMayor + ladoBaseMenor + ladoC + ladoD;
        }
    }
}
