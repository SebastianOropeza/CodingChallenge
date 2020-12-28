using CodingChallenge.Data.Idiomas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.FormasGeometricas
{
    public class Rectangulo : IFormaGeometrica
    {
        private readonly decimal ancho;
        private readonly decimal alto;

        public Rectangulo(decimal ancho, decimal alto)
        {
            this.ancho = ancho;
            this.alto = alto;
        }
        public decimal CalcularArea()
        {
            return ancho * alto;
        }

        public decimal CalcularPerimetro()
        {
            return 2 * (ancho + alto);
        }

        public string Traducir(IIdioma idioma, bool isPlural)
        {
            return idioma.TraducirRectangulo(isPlural);
        }
    }
}
