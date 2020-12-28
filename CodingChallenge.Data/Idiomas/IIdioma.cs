using CodingChallenge.Data.FormasGeometricas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Idiomas
{
    public interface IIdioma
    {
        string TraduccionFormas { get; }
        string TraduccionPerimetro { get; }
        string TraduccionArea { get; }
        string LineaReporteVacio { get; }
        string TituloReporte { get; }

        string TraducirForma(IFormaGeometrica forma, bool isPlural);
        string TraducirCirculo(bool isPlural);
        string TraducirTrianguloEquilatero(bool isPlural);
        string TraducirCuadrado(bool isPlural);
        string TraducirTrapecioIsoceles(bool isPlural);
        string TraducirRectangulo(bool isPlural);
    }
}
