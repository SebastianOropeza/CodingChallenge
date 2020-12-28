using CodingChallenge.Data.FormasGeometricas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Idiomas
{
    public class Castellano : IIdioma
    {
        public string TraduccionFormas => "formas";

        public string TraduccionPerimetro => "Perimetro";

        public string TraduccionArea => "Area";

        public string LineaReporteVacio => "<h1>Lista vacía de formas!</h1>";

        public string TituloReporte => "<h1>Reporte de Formas</h1>";

        public string TraducirCirculo(bool isPlural)
        {
            return isPlural ? "Círculos" : "Circulo";
        }

        public string TraducirCuadrado(bool isPlural)
        {
            return isPlural ? "Cuadrados" : "Cuadrado";
        }

        public string TraducirForma(IFormaGeometrica forma, bool isPlural)
        {
            return forma.Traducir(this, isPlural);
        }

        public string TraducirRectangulo(bool isPlural)
        {
            return isPlural ? "Rectangulos" : "Rectangulo";
        }

        public string TraducirTrapecioIsoceles(bool isPlural)
        {
            return isPlural ? "Trapecios" : "Trapecio";
        }

        public string TraducirTrianguloEquilatero(bool isPlural)
        {
            return isPlural ? "Triángulos" : "Triangulo";
        }
    }
}
