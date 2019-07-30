/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingChallenge.Data.Classes;

namespace CodingChallenge.Data.Vista
{
    public class Reporte
    {
        public static string Imprimir(List<FormaGeometrica> formas, Idioma idioma)
        {
            var sb = new StringBuilder();
            if (!formas.Any())
            {
                sb.Append("<h1>" + idioma.TextoListaVacia() + "</h1>");
            }
            else
            {
                List<LineaReportePorFigura> lineasPorFigura = new List<LineaReportePorFigura>();
                sb.Append("<h1>" + idioma.TextoCabecera() + "</h1>");
                LineaReportePorFigura nuevaLineaDeFormaGeometrica;
                bool figuraEncontrada;
                foreach (FormaGeometrica miFroma in formas)
                {
                    figuraEncontrada = false;
                    foreach (LineaReportePorFigura linea in lineasPorFigura)
                    {
                        if (linea.FormaGeometricaDeLinea.IdTipo == miFroma.IdTipo)
                        {
                            linea.Resultados.Cantidad++;
                            linea.Resultados.ResultadoArea += miFroma.CalcularArea();
                            linea.Resultados.ResultadoPerimetro += miFroma.CalcularPerimetro();
                            figuraEncontrada = true;
                            break;
                        }
                    }

                    /*
                    var result = (LineaReportePorFigura) (from item in lineasPorFigura where item.FormaGeometricaDeLinea.IdTipo == miFroma.IdTipo select item);
                    if (result == null)
                    {
                        ResultadosDeFigura nuevoResultado = new ResultadosDeFigura();
                        nuevoResultado.Cantidad = 1;
                        nuevoResultado.ResultadoArea = miFroma.CalcularArea();
                        nuevoResultado.ResultadoPerimetro = miFroma.CalcularPerimetro();
                        nuevaLineaDeFormaGeometrica = new LineaReportePorFigura(miFroma, nuevoResultado);
                        lineasPorFigura.Add(nuevaLineaDeFormaGeometrica);
                    }
                    else
                    {
                        result.Resultados.Cantidad++;
                        result.Resultados.ResultadoArea += miFroma.CalcularArea();
                        result.Resultados.ResultadoPerimetro += miFroma.CalcularPerimetro();
                    }
                    */
                    if (figuraEncontrada == false)
                    {
                        ResultadosDeFigura nuevoResultado = new ResultadosDeFigura();
                        nuevoResultado.Cantidad = 1;
                        nuevoResultado.ResultadoArea = miFroma.CalcularArea();
                        nuevoResultado.ResultadoPerimetro = miFroma.CalcularPerimetro();
                        nuevaLineaDeFormaGeometrica = new LineaReportePorFigura(miFroma, nuevoResultado);
                        lineasPorFigura.Add(nuevaLineaDeFormaGeometrica);
                    }
                }
                int totalFiguras = 0;
                decimal totalAreas = 0;
                decimal totalPerimietros = 0;

                foreach (LineaReportePorFigura linea in lineasPorFigura)
                {
                    sb.Append("<br>");
                    totalFiguras += linea.Resultados.Cantidad;
                    totalAreas += linea.Resultados.ResultadoArea;
                    totalPerimietros += linea.Resultados.ResultadoPerimetro;
                    sb.Append(idioma.TextoLinea(linea.Resultados, linea.FormaGeometricaDeLinea));
                }
                sb.Append("<br>");
                sb.Append(idioma.TextoPie(totalFiguras, totalAreas, totalPerimietros));
            }
            return sb.ToString();
        }
    }
}
