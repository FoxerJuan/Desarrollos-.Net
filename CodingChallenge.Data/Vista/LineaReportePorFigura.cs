using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingChallenge.Data.Classes;

namespace CodingChallenge.Data.Vista
{
    public class LineaReportePorFigura
    {
        private FormaGeometrica formaGeometricaDeLinea;
        private ResultadosDeFigura resultados;
        public FormaGeometrica FormaGeometricaDeLinea
        {
            set { formaGeometricaDeLinea = value; }
            get { return formaGeometricaDeLinea; }
        }
        public ResultadosDeFigura Resultados
        {
            set { resultados = value; }
            get { return resultados; }
        }

        public LineaReportePorFigura(FormaGeometrica _formaGeometricaDeLinea, ResultadosDeFigura _resultados)
        {
            formaGeometricaDeLinea = _formaGeometricaDeLinea;
            resultados = _resultados;
        }
    }
}
