using CodingChallenge.Data.FormasGeometricas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Idiomas
{
    public class Ingles : IIdioma
    {
        public string TraduccionFormas => "shapes";

        public string TraduccionPerimetro => "Perimeter";

        public string TraduccionArea => "Area";

        public string LineaReporteVacio => "<h1>Empty list of shapes!</h1>";

        public string TituloReporte => "<h1>Shapes report</h1>";

        public string TraducirCirculo(bool isPlural)
        {
            return isPlural ? "Circles" : "Circle";
        }

        public string TraducirCuadrado(bool isPlural)
        {
            return isPlural ? "Squares" : "Square";
        }

        public string TraducirForma(IFormaGeometrica forma, bool isPlural)
        {
            return forma.Traducir(this, isPlural);
        }

        public string TraducirRectangulo(bool isPlural)
        {
            return isPlural ? "Rectangles" : "Rectangle";
        }

        public string TraducirTrapecioIsoceles(bool isPlural)
        {
            return isPlural ? "Trapezoids" : "Trapeze";
        }

        public string TraducirTrianguloEquilatero(bool isPlural)
        {
            return isPlural ? "Triangles" : "Triangle";
        }
    }
}
