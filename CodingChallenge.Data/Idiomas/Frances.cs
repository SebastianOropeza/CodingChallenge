using CodingChallenge.Data.FormasGeometricas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Idiomas
{
    public class Frances : IIdioma
    {
        public string TraduccionFormas => "formes";

        public string TraduccionPerimetro => "Périmètre";

        public string TraduccionArea => "Area";

        public string LineaReporteVacio => "<h1>Liste de formes vide!</h1>";

        public string TituloReporte => "<h1>Rapport de formes</h1>";

        public string TraducirCirculo(bool isPlural)
        {
            return isPlural ? "Cercles" : "Cercle";
        }

        public string TraducirCuadrado(bool isPlural)
        {
            return isPlural ? "Carrés" : "Carré";
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
            return isPlural ? "Trapèze" : "Trapèze";
        }

        public string TraducirTrianguloEquilatero(bool isPlural)
        {
            return isPlural ? "Triangles" : "Triangle";
        }
    }
}
