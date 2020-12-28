/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */

using CodingChallenge.Data.FormasGeometricas;
using CodingChallenge.Data.Idiomas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Reporte
{
    public class Reporte
    {

        public static string Imprimir(List<IFormaGeometrica> formas, IIdioma idioma)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append(idioma.LineaReporteVacio);
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER
                sb.Append(idioma.TituloReporte);

                var diccionarioCantidadDeFormas = new Dictionary<string, int>();
                var diccionarioAreaDeFormas = new Dictionary<string, decimal>();
                var diccionarioPerimetroDeFormas = new Dictionary<string, decimal>();

                for (var i = 0; i < formas.Count; i++)
                {
                    var claveForma = formas[i].GetType().Name;

                    if (!diccionarioCantidadDeFormas.ContainsKey(claveForma))
                        diccionarioCantidadDeFormas.Add(claveForma, 0);

                    if (!diccionarioAreaDeFormas.ContainsKey(claveForma))
                        diccionarioAreaDeFormas.Add(claveForma, 0m);

                    if (!diccionarioPerimetroDeFormas.ContainsKey(claveForma))
                        diccionarioPerimetroDeFormas.Add(claveForma, 0m);

                    diccionarioCantidadDeFormas[claveForma] += 1;
                    diccionarioAreaDeFormas[claveForma] += formas[i].CalcularArea();
                    diccionarioPerimetroDeFormas[claveForma] += formas[i].CalcularPerimetro();
                }

                foreach (var claveForma in diccionarioCantidadDeFormas.Keys)
                {
                    var forma = formas.FirstOrDefault(f => f.GetType().Name.Equals(claveForma));

                    sb.Append(
                            ObtenerLinea(
                                    diccionarioCantidadDeFormas[claveForma],
                                    diccionarioAreaDeFormas[claveForma],
                                    diccionarioPerimetroDeFormas[claveForma],
                                    forma,
                                    idioma
                                )
                        );
                }

                // FOOTER
                sb.Append("TOTAL:<br/>");
                sb.Append(diccionarioCantidadDeFormas.Sum(e => e.Value) + " " + idioma.TraduccionFormas + " ");
                sb.Append(idioma.TraduccionPerimetro + " " + (diccionarioPerimetroDeFormas.Sum(e => e.Value)).ToString("#.##") + " ");
                sb.Append("Area " + (diccionarioAreaDeFormas.Sum(e => e.Value)).ToString("#.##"));
            }

            return sb.ToString();
        }

        private static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, IFormaGeometrica forma, IIdioma idioma)
        {
            return $"{cantidad} {idioma.TraducirForma(forma, isPlural: cantidad > 1)} | {idioma.TraduccionArea} {area:#.##} | {idioma.TraduccionPerimetro} {perimetro:#.##} <br/>";
        }

    }
}
