using CodingChallenge.Data.Idiomas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.FormasGeometricas
{
    public class Cuadrado : IFormaGeometrica
    {
        private readonly decimal lado;

        public Cuadrado(decimal lado)
        {
            this.lado = lado;
        }

        public decimal CalcularArea()
        {
            return lado * lado;
        }

        public decimal CalcularPerimetro()
        {
            return lado * 4;
        }

        public string Traducir(IIdioma idioma, bool isPlural)
        {
            return idioma.TraducirCuadrado(isPlural);
        }
    }
}
