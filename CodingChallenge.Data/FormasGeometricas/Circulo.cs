using CodingChallenge.Data.Idiomas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.FormasGeometricas
{
    public class Circulo : IFormaGeometrica
    {
        private readonly decimal radio;
        public Circulo(decimal radio)
        {
            this.radio = radio;
        }

        public decimal CalcularArea()
        {
            return (decimal)Math.PI * (radio / 2) * (radio / 2);
        }

        public decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * radio;
        }

        public string Traducir(IIdioma idioma, bool isPlural)
        {
            return idioma.TraducirCirculo(isPlural);
        }
    }
}
