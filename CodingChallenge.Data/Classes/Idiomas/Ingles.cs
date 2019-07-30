using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingChallenge.Data.Vista;

namespace CodingChallenge.Data.Classes.Idiomas
{
    public class Ingles : Idioma
    {
        public Ingles() : base()
        {
            this.IdIdioma = 2;
            this.Nombre = "INGLES";
        }
        public override string TextoCabecera()
        {
            return "Shapes report!";
        }
        public override string TextoListaVacia()
        {
            return "Empty list of shapes!";
        }
        public override string TextoLinea(ResultadosDeFigura _resultado, FormaGeometrica _forma)
        {
            string texto = "";
            texto = $"{_resultado.Cantidad} {TraducirForma(_forma, _resultado.Cantidad)} | Area {_resultado.ResultadoArea:#.##} | Perimeter {_resultado.ResultadoPerimetro:#.##}";
            return texto;
        }
        public override string TextoPie(int totalFormas, decimal totalAreas, decimal totalPerimetros)
        {
            string texto = "TOTAL: ";
            texto += $"{totalFormas} " + (totalFormas == 1 ? "shape" : "shapes") + $" Perimeter {totalPerimetros:#.##} Area {totalAreas:#.##}";
            return texto;
        }
        public override string TraducirForma(FormaGeometrica _forma, int _cantidad)
        {
            switch (_forma.IdTipo)
            {
                case 1:  //  Cuadrado
                    return (_cantidad == 1 ? "Square" : "Squares");
                case 2:  //  TrianguloEquilatero
                    return (_cantidad == 1 ? "Equilateral Triangle" : "Equilateral Triangles");
                case 3:  //  Circulo
                    return (_cantidad == 1 ? "Circle" : "Circles");
                case 4:  //  Trapecio
                    return (_cantidad == 1 ? "Trapeze" : "Trapezes");
                case 5:  //  Rectangulo
                    return (_cantidad == 1 ? "Rectangle" : "Rectangles");
                default:
                    return "Figure not defined in the English Language.";
            }
        }
    }
}
