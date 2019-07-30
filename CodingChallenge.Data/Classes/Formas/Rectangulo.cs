using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Formas
{
    public class Rectangulo : FormaGeometrica
    {
        private decimal ladoBase;
        private decimal ladoAltura;

        public Rectangulo(decimal _ladoBase, decimal _ladoAltura)
        {
            this.IdTipo = 5;
            this.Nombre = "Rectangulo";
            this.ladoBase = _ladoBase;
            this.ladoAltura = _ladoAltura;
            //this.ListadoLados = ;
        }
        public override decimal CalcularArea()
        {
            //return this.ListadoLados[0] * this.ListadoLados[1];
            return this.ladoBase * this.ladoAltura;
        }
        public override decimal CalcularPerimetro()
        {
            return this.ladoBase * 2 + this.ladoAltura * 2;
        }
    }
}
