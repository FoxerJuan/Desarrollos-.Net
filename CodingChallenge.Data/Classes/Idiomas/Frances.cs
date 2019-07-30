using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingChallenge.Data.Vista;

namespace CodingChallenge.Data.Classes.Idiomas
{
    public class Frances : Idioma
    {
        public Frances() : base()
        {
            this.IdIdioma = 3;
            this.Nombre = "FRANCES";
        }
        public override string TextoCabecera()
        {
            return "Rapport de formes!";
        }
        public override string TextoListaVacia()
        {
            return "Liste vide de formes!";
        }
        public override string TextoLinea(ResultadosDeFigura _resultado, FormaGeometrica _forma)
        {
            string texto = "";
            texto = $"{_resultado.Cantidad} {TraducirForma(_forma, _resultado.Cantidad)} | Zone {_resultado.ResultadoArea:#.##} | Périmètre {_resultado.ResultadoPerimetro:#.##}";
            return texto;
        }
        public override string TextoPie(int totalFormas, decimal totalAreas, decimal totalPerimetros)
        {
            string texto = "TOTAL: ";
            texto += $"{totalFormas} " + (totalFormas == 1 ? "forme" : "des formes") + $" Périmètre {totalPerimetros:#.##} Zone {totalAreas:#.##}";
            return texto;
        }
        public override string TraducirForma(FormaGeometrica _forma, int _cantidad)
        {
            switch (_forma.IdTipo)
            {
                case 1:  //  Cuadrado
                    return (_cantidad == 1 ? "Carré" : "Des Carrés");
                case 2:  //  TrianguloEquilatero
                    return (_cantidad == 1 ? "Triangle équilatéral" : "Triangles équilatéraux");
                case 3:  //  Circulo
                    return (_cantidad == 1 ? "Cercle" : "Cercles");
                case 4:  //  Trapecio
                    return (_cantidad == 1 ? "Trapèze" : "Trapèzes");
                case 5:  //  Rectangulo
                    return (_cantidad == 1 ? "Rectangle" : "Des Rectangles");
                default:
                    return "chiffre non défini en langue française.";
            }
        }
    }
}
