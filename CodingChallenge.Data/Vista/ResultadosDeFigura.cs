using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Vista
{
    public class ResultadosDeFigura
    {
        private int cantidad;
        decimal resultadoArea;
        decimal resultadoPerimetro;

        public ResultadosDeFigura()
        {
            this.cantidad = 0;
            this.resultadoArea = 0;
            this.resultadoPerimetro = 0;
        }
        public ResultadosDeFigura(int _cantidad, decimal _resultadoArea, decimal _resultadoPerimetro)
        {
            this.cantidad = _cantidad;
            this.resultadoArea = _resultadoArea;
            this.resultadoPerimetro = _resultadoPerimetro;
        }

        public int Cantidad
        {
            set { cantidad = value; }
            get { return cantidad; }
        }
        public decimal ResultadoArea
        {
            set { resultadoArea = value; }
            get { return resultadoArea; }
        }
        public decimal ResultadoPerimetro
        {
            set { resultadoPerimetro = value; }
            get { return resultadoPerimetro; }
        }
    }
}
