using System;
using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using NUnit.Framework;
using CodingChallenge.Data.Classes.Idiomas;
using CodingChallenge.Data.Classes.Formas;
using CodingChallenge.Data.Vista;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        Circulo circulo;
        Cuadrado cuadrado;
        Rectangulo rectangulo;
        Trapecio trapecio;
        TrianguloEquilatero trianguloEquilatero;

        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>", Reporte.Imprimir(new List<FormaGeometrica>(), new Español()));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>", Reporte.Imprimir(new List<FormaGeometrica>(), new Ingles()));
        }
        
        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            List<FormaGeometrica> formasGeometricas = new List<FormaGeometrica>();
            cuadrado = new Cuadrado(5);
            formasGeometricas.Add(cuadrado);
            var resumen = Reporte.Imprimir(formasGeometricas, new Español());
            Assert.AreEqual("<h1>Reporte de Formas!</h1><br>1 Cuadrado | Area 25 | Perimetro 20<br>TOTAL: 1 forma Perimetro 20 Area 25", resumen);
        }
        
        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            List<FormaGeometrica> formasGeometricas = new List<FormaGeometrica>();
            formasGeometricas = new List<FormaGeometrica>();
            cuadrado = new Cuadrado(1);
            formasGeometricas.Add(cuadrado);
            cuadrado = new Cuadrado(3);
            formasGeometricas.Add(cuadrado);
            cuadrado = new Cuadrado(5);
            formasGeometricas.Add(cuadrado);

            var resumen = Reporte.Imprimir(formasGeometricas, new Ingles());
            Assert.AreEqual("<h1>Shapes report!</h1><br>3 Squares | Area 35 | Perimeter 36<br>TOTAL: 3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnIngles()
        {
            List<FormaGeometrica> formasGeometricas = new List<FormaGeometrica>();

            cuadrado = new Cuadrado(5);
            formasGeometricas.Add(cuadrado);

            circulo = new Circulo(3);
            formasGeometricas.Add(circulo);

            trianguloEquilatero = new TrianguloEquilatero(4);
            formasGeometricas.Add(trianguloEquilatero);

            cuadrado = new Cuadrado(2);
            formasGeometricas.Add(cuadrado);

            trianguloEquilatero = new TrianguloEquilatero(9);
            formasGeometricas.Add(trianguloEquilatero);

            circulo = new Circulo(2.75m);
            formasGeometricas.Add(circulo);

            trianguloEquilatero = new TrianguloEquilatero(4.2m);
            formasGeometricas.Add(trianguloEquilatero);

            var resumen = Reporte.Imprimir(formasGeometricas, new Ingles());
            Assert.AreEqual(
                "<h1>Shapes report!</h1><br>2 Squares | Area 29 | Perimeter 28<br>2 Circles | Area 13,01 | Perimeter 18,06<br>3 Equilateral Triangles | Area 49,64 | Perimeter 51,6<br>TOTAL: 7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }
        
        [TestCase]
        public void TestResumenListaConMasTiposEnEspañol()
        {
            List<FormaGeometrica> formasGeometricas = new List<FormaGeometrica>();

            cuadrado = new Cuadrado(5);
            formasGeometricas.Add(cuadrado);

            circulo = new Circulo(3);
            formasGeometricas.Add(circulo);

            trianguloEquilatero = new TrianguloEquilatero(4);
            formasGeometricas.Add(trianguloEquilatero);

            cuadrado = new Cuadrado(2);
            formasGeometricas.Add(cuadrado);

            trianguloEquilatero = new TrianguloEquilatero(9);
            formasGeometricas.Add(trianguloEquilatero);

            circulo = new Circulo(2.75m);
            formasGeometricas.Add(circulo);

            trianguloEquilatero = new TrianguloEquilatero(4.2m);
            formasGeometricas.Add(trianguloEquilatero);

            var resumen = Reporte.Imprimir(formasGeometricas, new Español());
            Assert.AreEqual("<h1>Reporte de Formas!</h1><br>2 Cuadrados | Area 29 | Perimetro 28<br>2 Círculos | Area 13,01 | Perimetro 18,06<br>3 Triángulos Equilateros | Area 49,64 | Perimetro 51,6<br>TOTAL: 7 formas Perimetro 97,66 Area 91,65", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnFrances()
        {
            List<FormaGeometrica> formasGeometricas = new List<FormaGeometrica>();

            cuadrado = new Cuadrado(5);
            formasGeometricas.Add(cuadrado);

            circulo = new Circulo(3);
            formasGeometricas.Add(circulo);

            trianguloEquilatero = new TrianguloEquilatero(4);
            formasGeometricas.Add(trianguloEquilatero);

            cuadrado = new Cuadrado(2);
            formasGeometricas.Add(cuadrado);

            trianguloEquilatero = new TrianguloEquilatero(9);
            formasGeometricas.Add(trianguloEquilatero);

            var resumen = Reporte.Imprimir(formasGeometricas, new Frances());
            Assert.AreEqual("<h1>Rapport de formes!</h1><br>2 Des Carrés | Zone 29 | Périmètre 28<br>1 Cercle | Zone 7,07 | Périmètre 9,42<br>2 Triangles équilatéraux | Zone 42 | Périmètre 39<br>TOTAL: 5 des formes Périmètre 76,42 Zone 78,07", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrapecioEnIngles()
        {
            List<FormaGeometrica> formasGeometricas = new List<FormaGeometrica>();

            trapecio = new Trapecio(7, 3, 5, 4.12m);
            formasGeometricas.Add(trapecio);

            var resumen = Reporte.Imprimir(formasGeometricas, new Ingles());
            Assert.AreEqual("<h1>Shapes report!</h1><br>1 Trapeze | Area 19,99 | Perimeter 19,12<br>TOTAL: 1 shape Perimeter 19,12 Area 19,99", resumen);
        }

        [TestCase]
        public void TestResumenListaConTrapecioYRectanguloEnFrances()
        {
            List<FormaGeometrica> formasGeometricas = new List<FormaGeometrica>();
            
            trapecio = new Trapecio(7, 3, 5, 4.12m);
            formasGeometricas.Add(trapecio);
            
            rectangulo = new Rectangulo(2,3);
            formasGeometricas.Add(rectangulo);

            trapecio = new Trapecio(7, 3, 5, 4.12m);
            formasGeometricas.Add(trapecio);

            rectangulo = new Rectangulo(2, 4);
            formasGeometricas.Add(rectangulo);

            var resumen = Reporte.Imprimir(formasGeometricas, new Frances());
            Assert.AreEqual("<h1>Rapport de formes!</h1><br>2 Trapèzes | Zone 39,98 | Périmètre 38,24<br>2 Des Rectangles | Zone 14 | Périmètre 22<br>TOTAL: 4 des formes Périmètre 60,24 Zone 53,98", resumen);
        }

    }
}
