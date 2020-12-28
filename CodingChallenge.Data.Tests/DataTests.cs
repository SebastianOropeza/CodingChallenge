using System;
using System.Collections.Generic;
using CodingChallenge.Data.Reporte;
using CodingChallenge.Data.FormasGeometricas;
using CodingChallenge.Data.Idiomas;
using NUnit.Framework;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                Reporte.Reporte.Imprimir(new List<IFormaGeometrica>(), new Castellano()));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                Reporte.Reporte.Imprimir(new List<IFormaGeometrica>(), new Ingles()));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<IFormaGeometrica> {new Cuadrado(5)};

            var resumen = Reporte.Reporte.Imprimir(cuadrados, new Castellano());

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = Reporte.Reporte.Imprimir(cuadrados, new Ingles());

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = Reporte.Reporte.Imprimir(formas, new Ingles());

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = Reporte.Reporte.Imprimir(formas, new Castellano());

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void ResumenListaConUnTrapecioEnCastellano()
        {
            var formas = new List<IFormaGeometrica>
            {
                new TrapecioIsoceles(baseMayor: 10, baseMenor: 5, altura: 8)
            };

            var resumen = Reporte.Reporte.Imprimir(formas, new Castellano());

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Trapecio | Area 60 | Perimetro 155,5 <br/>TOTAL:<br/>1 formas Perimetro 155,5 Area 60", resumen);
        }

        [TestCase]
        public void ResumenListaConTrapeciosEnCastellano()
        {
            var formas = new List<IFormaGeometrica>
            {
                new TrapecioIsoceles(baseMayor: 10, baseMenor: 5, altura: 8),
                new TrapecioIsoceles(baseMayor: 6, baseMenor: 5, altura: 7)
            };

            var resumen = Reporte.Reporte.Imprimir(formas, new Castellano());

            Assert.AreEqual("<h1>Reporte de Formas</h1>2 Trapecios | Area 98,5 | Perimetro 265 <br/>TOTAL:<br/>2 formas Perimetro 265 Area 98,5", resumen);
        }

        [TestCase]
        public void ResumenListaConUnTrapecioEnIngles()
        {
            var formas = new List<IFormaGeometrica>
            {
                new TrapecioIsoceles(baseMayor: 6, baseMenor: 5, altura: 7)
            };

            var resumen = Reporte.Reporte.Imprimir(formas, new Ingles());

            Assert.AreEqual("<h1>Shapes report</h1>1 Trapeze | Area 38,5 | Perimeter 109,5 <br/>TOTAL:<br/>1 shapes Perimeter 109,5 Area 38,5", resumen);
        }

        [TestCase]
        public void ResumenListaConTrapeciosEnIngles()
        {
            var formas = new List<IFormaGeometrica>
            {
                new TrapecioIsoceles(baseMayor: 10, baseMenor: 5, altura: 8),
                new TrapecioIsoceles(baseMayor: 6, baseMenor: 5, altura: 7)
            };

            var resumen = Reporte.Reporte.Imprimir(formas, new Ingles());

            Assert.AreEqual("<h1>Shapes report</h1>2 Trapezoids | Area 98,5 | Perimeter 265 <br/>TOTAL:<br/>2 shapes Perimeter 265 Area 98,5", resumen);
        }

        [TestCase]
        public void ResumenListaConUnRectanguloEnCastellano()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Rectangulo(ancho: 5, alto: 7)
            };

            var resumen = Reporte.Reporte.Imprimir(formas, new Castellano());

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Rectangulo | Area 35 | Perimetro 24 <br/>TOTAL:<br/>1 formas Perimetro 24 Area 35", resumen);
        }

        [TestCase]
        public void ResumenListaConRectangulosEnCastellano()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Rectangulo(ancho: 7, alto: 3),
                new Rectangulo(ancho: 10, alto: 4)
            };

            var resumen = Reporte.Reporte.Imprimir(formas, new Castellano());

            Assert.AreEqual("<h1>Reporte de Formas</h1>2 Rectangulos | Area 61 | Perimetro 48 <br/>TOTAL:<br/>2 formas Perimetro 48 Area 61", resumen);
        }

        [TestCase]
        public void ResumenListaConUnRectanguloEnIngles()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Rectangulo(ancho: 5, alto: 7)
            };

            var resumen = Reporte.Reporte.Imprimir(formas, new Ingles());

            Assert.AreEqual("<h1>Shapes report</h1>1 Rectangle | Area 35 | Perimeter 24 <br/>TOTAL:<br/>1 shapes Perimeter 24 Area 35", resumen);
        }

        [TestCase]
        public void ResumenListaConRectanguloEnIngles()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Rectangulo(ancho: 7, alto: 3),
                new Rectangulo(ancho: 10, alto: 4)
            };

            var resumen = Reporte.Reporte.Imprimir(formas, new Ingles());

            Assert.AreEqual("<h1>Shapes report</h1>2 Rectangles | Area 61 | Perimeter 48 <br/>TOTAL:<br/>2 shapes Perimeter 48 Area 61", resumen);
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnFrances()
        {
            Assert.AreEqual("<h1>Liste de formes vide!</h1>",
                Reporte.Reporte.Imprimir(new List<IFormaGeometrica>(), new Frances()));
        }

        [TestCase]
        public void ResumenListaConUnaFormaEnFrances()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(lado: 5)
            };

            var resumen = Reporte.Reporte.Imprimir(formas, new Frances());

            Assert.AreEqual("<h1>Rapport de formes</h1>1 Carré | Area 25 | Périmètre 20 <br/>TOTAL:<br/>1 formes Périmètre 20 Area 25", resumen);
        }

        [TestCase]
        public void ResumenListaConVariasFormasEnFrances()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(lado: 5),
                new Cuadrado(lado: 5),
                new TrianguloEquilatero(lado: 6)
            };

            var resumen = Reporte.Reporte.Imprimir(formas, new Frances());

            Assert.AreEqual("<h1>Rapport de formes</h1>2 Carrés | Area 50 | Périmètre 40 <br/>1 Triangle | Area 15,59 | Périmètre 18 <br/>TOTAL:<br/>3 formes Périmètre 58 Area 65,59", resumen);
        }
    }
}
