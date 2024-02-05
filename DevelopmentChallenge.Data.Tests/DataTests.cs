using System;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Enum;
using DevelopmentChallenge.Data.Models;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                FormaGeometrica.Imprimir(new List<FormaGeometrica>(), (int)Idiomas.Castellano));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                FormaGeometrica.Imprimir(new List<FormaGeometrica>(), (int)Idiomas.Ingles));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnItaliano()
        {
            Assert.AreEqual("<h1>Elenco vuoto di forme!</h1>",
                FormaGeometrica.Imprimir(new List<FormaGeometrica>(), (int)Idiomas.Italiano));
        }

        [TestCase]
        public void TestResumenListaConUnCuadradoMultiIdioma()
        {
            var cuadrados = new List<FormaGeometrica> { new FormaGeometrica((int)FormasGeometricas.Cuadrado, 5) };

            var resumen = FormaGeometrica.Imprimir(cuadrados, (int)Idiomas.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
            var resumenIng = FormaGeometrica.Imprimir(cuadrados, (int)Idiomas.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>1 Square | Area 25 | Perimeter 20 <br/>TOTAL:<br/>1 shapes Perimeter 20 Area 25", resumenIng);
            var resumenIta = FormaGeometrica.Imprimir(cuadrados, (int)Idiomas.Italiano);

            Assert.AreEqual("<h1>Rapporto moduli</h1>1 Piazza | zona 25 | Perimetro 20 <br/>TOTALE:<br/>1 forme Perimetro 20 zona 25", resumenIta);
        }
        [TestCase]
        public void TestResumenListaConUnCirculoMultiIdioma()
        {
            var circulo = new List<FormaGeometrica> { new FormaGeometrica((int)FormasGeometricas.Circulo, radio: 3) };

            var resumen = FormaGeometrica.Imprimir(circulo, (int)Idiomas.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Círculo | Area 28.27 | Perimetro 18.85 <br/>TOTAL:<br/>1 formas Perimetro 18.85 Area 28.27", resumen);

            var resumenIng = FormaGeometrica.Imprimir(circulo, (int)Idiomas.Ingles);
            Assert.AreEqual("<h1>Shapes report</h1>1 Circle | Area 28.27 | Perimeter 18.85 <br/>TOTAL:<br/>1 shapes Perimeter 18.85 Area 28.27", resumenIng);

            var resumenIta = FormaGeometrica.Imprimir(circulo, (int)Idiomas.Italiano);
            Assert.AreEqual("<h1>Rapporto moduli</h1>1 Cerchio | zona 28.27 | Perimetro 18.85 <br/>TOTALE:<br/>1 forme Perimetro 18.85 zona 28.27", resumenIta);

        }
        [TestCase]
        public void TestResumenListaConUnTrianguloMultiIdioma()
        {
            var cuadrados = new List<FormaGeometrica> { new FormaGeometrica((int)FormasGeometricas.TrianguloEquilatero, baseMenor:5,altura:3) };

            var resumen = FormaGeometrica.Imprimir(cuadrados, (int)Idiomas.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Triangulo | Area 7.5 | Perimetro 15 <br/>TOTAL:<br/>1 formas Perimetro 15 Area 7.5", resumen);
            var resumenIng = FormaGeometrica.Imprimir(cuadrados, (int)Idiomas.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>1 Triangle | Area 7.5 | Perimeter 15 <br/>TOTAL:<br/>1 shapes Perimeter 15 Area 7.5", resumenIng);
            var resumenIta = FormaGeometrica.Imprimir(cuadrados, (int)Idiomas.Italiano);

            Assert.AreEqual("<h1>Rapporto moduli</h1>1 Triangolo | zona 7.5 | Perimetro 15 <br/>TOTALE:<br/>1 forme Perimetro 15 zona 7.5", resumenIta);
        }
        [TestCase]
        public void TestResumenListaConUnTrapecioMultiIdioma()
        {
            var cuadrados = new List<FormaGeometrica> { new FormaGeometrica((int)FormasGeometricas.Trapecio, baseMenor:5,baseMayor:6,altura:4) };

            var resumen = FormaGeometrica.Imprimir(cuadrados, (int)Idiomas.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Trapecio | Area 22 | Perimetro 19 <br/>TOTAL:<br/>1 formas Perimetro 19 Area 22", resumen);
            var resumenIng = FormaGeometrica.Imprimir(cuadrados, (int)Idiomas.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>1 Trapeze | Area 22 | Perimeter 19 <br/>TOTAL:<br/>1 shapes Perimeter 19 Area 22", resumenIng);
            var resumenIta = FormaGeometrica.Imprimir(cuadrados, (int)Idiomas.Italiano);

            Assert.AreEqual("<h1>Rapporto moduli</h1>1 Trapezio | zona 22 | Perimetro 19 <br/>TOTALE:<br/>1 forme Perimetro 19 zona 22", resumenIta);
        }
        [TestCase]
        public void TestResumenListaConUnRectanguloMultiIdioma()
        {
            var cuadrados = new List<FormaGeometrica> { new FormaGeometrica((int)FormasGeometricas.Rectangulo, ancho:5,ladob:4) };

            var resumen = FormaGeometrica.Imprimir(cuadrados, (int)Idiomas.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Rectangulo | Area 20 | Perimetro 18 <br/>TOTAL:<br/>1 formas Perimetro 18 Area 20", resumen);
            var resumenIng = FormaGeometrica.Imprimir(cuadrados, (int)Idiomas.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>1 Rectangle | Area 20 | Perimeter 18 <br/>TOTAL:<br/>1 shapes Perimeter 18 Area 20", resumenIng);
            var resumenIta = FormaGeometrica.Imprimir(cuadrados, (int)Idiomas.Italiano);

            Assert.AreEqual("<h1>Rapporto moduli</h1>1 Rettangolo | zona 20 | Perimetro 18 <br/>TOTALE:<br/>1 forme Perimetro 18 zona 20", resumenIta);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new FormaGeometrica((int)FormasGeometricas.Cuadrado, 5),
                new FormaGeometrica((int)FormasGeometricas.Cuadrado, 1),
                new FormaGeometrica((int)FormasGeometricas.Cuadrado, 3)
            };

            var resumen = FormaGeometrica.Imprimir(cuadrados, (int)Idiomas.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 80 Area 86", resumen);
        }

        [TestCase]
        public void TestResumenListaConTodasLasFigurasMultiIdioma()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new FormaGeometrica((int)FormasGeometricas.Cuadrado, 5),  
                new FormaGeometrica((int)FormasGeometricas.Circulo, radio:3),
                new FormaGeometrica((int)FormasGeometricas.TrianguloEquilatero, baseMenor:4,altura:3),
                new FormaGeometrica((int)FormasGeometricas.Rectangulo, ancho:5,ladob:4),
                new FormaGeometrica((int)FormasGeometricas.Trapecio, baseMenor:5,baseMayor:6,altura:4)
        };

            var resumen = FormaGeometrica.Imprimir(cuadrados, (int)Idiomas.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>1 Square | Area 25 | Perimeter 20 <br/>1 Circle | Area 28.27 | Perimeter 18.85 <br/>1 Rectangle | Area 20 | Perimeter 18 <br/>1 Triangle | Area 6 | Perimeter 12 <br/>1 Trapeze | Area 22 | Perimeter 19 <br/>TOTAL:<br/>5 shapes Perimeter 87.85 Area 101.27", resumen);
        }


        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica((int)FormasGeometricas.Cuadrado, ancho:5),
                new FormaGeometrica((int)FormasGeometricas.Circulo, radio:3),
                new FormaGeometrica((int)FormasGeometricas.TrianguloEquilatero, baseMenor:4,altura:3),
                new FormaGeometrica((int)FormasGeometricas.Cuadrado, ancho:2),
                new FormaGeometrica((int)FormasGeometricas.TrianguloEquilatero, baseMenor : 9,altura:3),
                new FormaGeometrica((int)FormasGeometricas.Circulo, radio:2.75),
                new FormaGeometrica((int)FormasGeometricas.TrianguloEquilatero, baseMenor:4.2,altura:3)
            };

            var resumen = FormaGeometrica.Imprimir(formas, (int)Idiomas.Ingles);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 52.03 | Perimeter 36.13 <br/>3 Triangles | Area 25.8 | Perimeter 51.6 <br/>TOTAL:<br/>7 shapes Perimeter 205.58 Area 185.61",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica((int)FormasGeometricas.Cuadrado, ancho:5),
                new FormaGeometrica((int)FormasGeometricas.Circulo, radio:3),
                new FormaGeometrica((int)FormasGeometricas.TrianguloEquilatero, baseMenor:4,altura:3),
                new FormaGeometrica((int)FormasGeometricas.Cuadrado, ancho:2),
                new FormaGeometrica((int)FormasGeometricas.TrianguloEquilatero, baseMenor:9,altura:3),
                new FormaGeometrica((int)FormasGeometricas.Circulo, radio:2.75),
                new FormaGeometrica((int)FormasGeometricas.TrianguloEquilatero, baseMenor:4.2,altura:3)
            };

            var resumen = FormaGeometrica.Imprimir(formas, (int)Idiomas.Castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 52.03 | Perimetro 36.13 <br/>3 Triángulos | Area 25.8 | Perimetro 51.6 <br/>TOTAL:<br/>7 formas Perimetro 205.58 Area 185.61",
                resumen);
        }
        [TestCase]
        public void TestResumenListaConMasTiposEnItaliano()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica((int)FormasGeometricas.Cuadrado, ancho:5),
                new FormaGeometrica((int)FormasGeometricas.Circulo, radio:3),
                new FormaGeometrica((int)FormasGeometricas.TrianguloEquilatero, baseMenor:4,altura:3),
                new FormaGeometrica((int)FormasGeometricas.Cuadrado, ancho:2),
                new FormaGeometrica((int)FormasGeometricas.TrianguloEquilatero, baseMenor:9,altura:3),
                new FormaGeometrica((int)FormasGeometricas.Circulo, radio:2.75),
                new FormaGeometrica((int)FormasGeometricas.TrianguloEquilatero, baseMenor:4.2,altura:3)
            };

            var resumen = FormaGeometrica.Imprimir(formas, (int)Idiomas.Italiano);

            Assert.AreEqual(
                "<h1>Rapporto moduli</h1>2 Piazze | zona 29 | Perimetro 28 <br/>2 Cerchi | zona 52.03 | Perimetro 36.13 <br/>3 triangoli | zona 25.8 | Perimetro 51.6 <br/>TOTALE:<br/>7 forme Perimetro 205.58 zona 185.61",
                resumen);
        }
    }
}
