using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingChallenge.Data.Vista;

namespace CodingChallenge.Data.Classes.Idiomas
{
    public class Español : Idioma
    {
        public Español() : base() {
            this.IdIdioma = 1;
            this.Nombre = "ESPAÑOL";
        }
        public override string TextoCabecera()
        {
            return "Reporte de Formas!";
        }
        public override string TextoListaVacia()
        {
            return "Lista vacía de formas!";
        }
        public override string TextoLinea(ResultadosDeFigura _resultado, FormaGeometrica _forma)
        {
            string texto = "";
            texto = $"{_resultado.Cantidad} {TraducirForma(_forma, _resultado.Cantidad)} | Area {_resultado.ResultadoArea:#.##} | Perimetro {_resultado.ResultadoPerimetro:#.##}";
            return texto;
        }
        public override string TextoPie(int totalFormas, decimal totalAreas, decimal totalPerimetros)
        {
            string texto = "TOTAL: ";
            texto += $"{totalFormas} " + (totalFormas == 1 ? "forma" : "formas") + $" Perimetro {totalPerimetros:#.##} Area {totalAreas:#.##}";
            return texto;
        }

        public override string TraducirForma(FormaGeometrica _forma, int _cantidad)
        {
            switch (_forma.IdTipo)
            {
                case 1:  //  Cuadrado
                    return (_cantidad == 1 ? "Cuadrado" : "Cuadrados");
                case 2:  //  TrianguloEquilatero
                    return (_cantidad == 1 ? "Triángulos Equilatero" : "Triángulos Equilateros");
                case 3:  //  Circulo
                    return (_cantidad == 1 ? "Círculo" : "Círculos");
                case 4:  //  Trapecio
                    return (_cantidad == 1 ? "Trapecio" : "Trapecios");
                case 5:  //  Rectangulo
                    return (_cantidad == 1 ? "Rectangulo" : "Rectangulos");
                default:
                    return "figura no definida en el Idioma Español.";
            }
        }
    }
}
