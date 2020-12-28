using CodingChallenge.Data.Idiomas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.FormasGeometricas
{
    public class TrapecioIsoceles : IFormaGeometrica
    {
        private readonly decimal baseMayor;
        private readonly decimal baseMenor;
        private readonly decimal altura;

        public TrapecioIsoceles(decimal baseMayor, decimal baseMenor, decimal altura)
        {
            if (baseMayor == baseMenor)
                throw new Exception("Las bases de un Trapecio deben ser de tamaño distinto");
            if (baseMayor < baseMenor)
                throw new Exception("Las base mayor debe ser mayor a la base menor");

            this.baseMayor = baseMayor;
            this.baseMenor = baseMenor;
            this.altura = altura;
        }

        public decimal CalcularArea()
        {
            return ((baseMayor + baseMenor) / 2) * altura;
        }

        public decimal CalcularPerimetro()
        {
            var baseTrianguloDeUnLado = (baseMayor - baseMenor) / 2;
            var tamañoLado = (baseTrianguloDeUnLado * baseTrianguloDeUnLado) + (altura * altura);

            return baseMayor + baseMenor + (2 * tamañoLado);
        }

        public string Traducir(IIdioma idioma, bool isPlural)
        {
            return idioma.TraducirTrapecioIsoceles(isPlural);
        }
    }
}
