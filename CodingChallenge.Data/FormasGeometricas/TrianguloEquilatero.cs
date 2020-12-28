using CodingChallenge.Data.Idiomas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.FormasGeometricas
{
    public class TrianguloEquilatero : IFormaGeometrica
    {
        private readonly decimal lado;
        public TrianguloEquilatero(decimal lado)
        {
            this.lado = lado;
        }

        public decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * lado * lado;
        }

        public decimal CalcularPerimetro()
        {
            return lado * 3;
        }

        public string Traducir(IIdioma idioma, bool isPlural)
        {
            return idioma.TraducirTrianguloEquilatero(isPlural);
        }
    }
}
