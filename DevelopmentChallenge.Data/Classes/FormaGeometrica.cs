/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

/*
 * TODO: 
 * Refactorizar la clase para respetar principios de la programación orientada a objetos.
 * Implementar la forma Trapecio/Rectangulo. 
 * Agregar el idioma Italiano (o el deseado) al reporte.
 * Se agradece la inclusión de nuevos tests unitarios para validar el comportamiento de la nueva funcionalidad agregada (los tests deben pasar correctamente al entregar la solución, incluso los actuales.)
 * Una vez finalizado, hay que subir el código a un repo GIT y ofrecernos la URL para que podamos utilizar la nueva versión :).
 */

using DevelopmentChallenge.Data.Enum;
using DevelopmentChallenge.Data.Models;
using DevelopmentChallenge.Data.Recursos;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace DevelopmentChallenge.Data.Classes
{
    public class FormaGeometrica
    {
        private readonly double _lado;
        private readonly double _radio;
        private readonly double _baseMayor;
        private readonly double _base;
        private readonly double _altura;
        private readonly double _ladob;
        private readonly List<IForma> formas1 = new List<IForma>();

        public int Tipo { get; set; }

        public FormaGeometrica(int tipo, double ancho = 0, double radio = 0, double baseMayor = 0, double baseMenor = 0, double altura = 0, double ladob = 0)
        {
            Tipo = tipo;
            _lado = ancho;
            _radio=radio;
            _baseMayor=baseMayor;
            _base= baseMenor;
            _altura=altura;
            _ladob=ladob;
        }
        public FormaGeometrica(List<IForma> formas)
        {
            formas1 = formas;
        }
        public static string Imprimir(List<FormaGeometrica> formas, int idioma)
        {
            var sb = new StringBuilder();
            var totalizador = new Totalizador();

            //TODO: lo mejor seria cambiar a un esquema en el que el idioma se tome directamente desde la localizacion del usuario pero para respetar lo pedido en el ejercicio se deja de esta manera
            SeleccionIdioma(idioma);

            if (formas.Count == 0)
            {
                sb.Append(Traduccion.ListaVacia);
            }
            else
            {
                sb.Append(Traduccion.ReporteFormas);

                ConstructorFormas(formas, totalizador);

                AgregarLineas(sb, totalizador);

            }
            return sb.ToString();
        }

        private static void AgregarLineas(StringBuilder sb, Totalizador totalizador)
        {
            if (totalizador.contadorFormas.Any(e => e.Key == FormasGeometricas.Cuadrado))
            {
                sb.Append($"{totalizador.contadorFormas.Where(e => e.Key == FormasGeometricas.Cuadrado).FirstOrDefault().Value} {(totalizador.contadorFormas.Where(e => e.Key == FormasGeometricas.Cuadrado).FirstOrDefault().Value > 1 ? Traduccion.Cuadrados:Traduccion.Cuadrado)} |" +
                                       $" {Traduccion.Area} {totalizador.totalAreas.Where(e => e.Key == FormasGeometricas.Cuadrado).FirstOrDefault().Value.ToString("0.##")} |" +
                                       $" {Traduccion.Perimetro} {totalizador.totalPerimetros.Where(e => e.Key == FormasGeometricas.Cuadrado).FirstOrDefault().Value.ToString("0.##")} <br/>");
            }
            if (totalizador.contadorFormas.Any(e => e.Key == FormasGeometricas.Circulo))
            {
                sb.Append($"{totalizador.contadorFormas.Where(e => e.Key == FormasGeometricas.Circulo).FirstOrDefault().Value} {(totalizador.contadorFormas.Where(e => e.Key == FormasGeometricas.Circulo).FirstOrDefault().Value>1?Traduccion.Circulos:Traduccion.Circulo)} |" +
                                       $" {Traduccion.Area} {totalizador.totalAreas.Where(e => e.Key == FormasGeometricas.Circulo).FirstOrDefault().Value.ToString("0.##")} |" +
                                       $" {Traduccion.Perimetro} {totalizador.totalPerimetros.Where(e => e.Key == FormasGeometricas.Circulo).FirstOrDefault().Value.ToString("0.##")} <br/>");
            }
            if (totalizador.contadorFormas.Any(e => e.Key == FormasGeometricas.Rectangulo))
            {
                sb.Append($"{totalizador.contadorFormas.Where(e => e.Key == FormasGeometricas.Rectangulo).FirstOrDefault().Value} {(totalizador.contadorFormas.Where(e => e.Key == FormasGeometricas.Rectangulo).FirstOrDefault().Value > 1 ? Traduccion.Rectangulos : Traduccion.Rectangulo)} |" +
                                       $" {Traduccion.Area} {totalizador.totalAreas.Where(e => e.Key == FormasGeometricas.Rectangulo).FirstOrDefault().Value.ToString("0.##")} |" +
                                       $" {Traduccion.Perimetro} {totalizador.totalPerimetros.Where(e => e.Key == FormasGeometricas.Rectangulo).FirstOrDefault().Value.ToString("0.##")} <br/>");
            }
            if (totalizador.contadorFormas.Any(e => e.Key == FormasGeometricas.TrianguloEquilatero))
            {
                sb.Append($"{totalizador.contadorFormas.Where(e => e.Key == FormasGeometricas.TrianguloEquilatero).FirstOrDefault().Value} {(totalizador.contadorFormas.Where(e => e.Key == FormasGeometricas.TrianguloEquilatero).FirstOrDefault().Value > 1 ? Traduccion.Triangulos : Traduccion.Triangulo)} |" +
                                       $" {Traduccion.Area} {totalizador.totalAreas.Where(e => e.Key == FormasGeometricas.TrianguloEquilatero).FirstOrDefault().Value.ToString("0.##")} |" +
                                       $" {Traduccion.Perimetro} {totalizador.totalPerimetros.Where(e => e.Key == FormasGeometricas.TrianguloEquilatero).FirstOrDefault().Value.ToString("0.##")} <br/>");
            }
            if (totalizador.contadorFormas.Any(e => e.Key == FormasGeometricas.Trapecio))
            {
                sb.Append($"{totalizador.contadorFormas.Where(e => e.Key == FormasGeometricas.Trapecio).FirstOrDefault().Value} {(totalizador.contadorFormas.Where(e => e.Key == FormasGeometricas.Trapecio).FirstOrDefault().Value > 1 ? Traduccion.Trapecios : Traduccion.Trapecio)} |" +
                                       $" {Traduccion.Area} {totalizador.totalAreas.Where(e => e.Key == FormasGeometricas.Trapecio).FirstOrDefault().Value.ToString("0.##")} |" +
                                       $" {Traduccion.Perimetro} {totalizador.totalPerimetros.Where(e => e.Key == FormasGeometricas.Trapecio).FirstOrDefault().Value.ToString("0.##")} <br/>");
            }

            sb.Append(Traduccion.Total);
            sb.Append($"{totalizador.totalFiguras.ToString("0.##")} {Traduccion.Formas} ");
            sb.Append($"{Traduccion.Perimetro} {totalizador.totalGeneralPerimetro.ToString("0.##")} ");
            sb.Append($"{Traduccion.Area} {totalizador.totalGeneralArea.ToString("0.##")}");
        }

        private static void ConstructorFormas(List<FormaGeometrica> formas, Totalizador totalizador)
        {
            foreach (var item in formas)
            {
                switch (item.Tipo)
                {
                    case (int)FormasGeometricas.Circulo:
                        var circuloBuilder = new FormaBuilder(new Circulo { Radio = item._radio });
                        var directorCirculo = new DirectorForma();
                        directorCirculo.ConstruirForma(circuloBuilder);

                        totalizador.AgregarFormaGeometrica(circuloBuilder);
                        break;
                    case (int)FormasGeometricas.Cuadrado:
                        var cuadradoBuilder = new FormaBuilder(new Cuadrado { Lado = item._lado });
                        var directorCuadrado = new DirectorForma();
                        directorCuadrado.ConstruirForma(cuadradoBuilder);

                        totalizador.AgregarFormaGeometrica(cuadradoBuilder);

                        break;
                    case (int)FormasGeometricas.Rectangulo:
                        var rectanguloBuilder = new FormaBuilder(new Rectangulo { LadoA = item._lado,LadoB=item._ladob });
                        var directorRectangulo = new DirectorForma();
                        directorRectangulo.ConstruirForma(rectanguloBuilder);

                        totalizador.AgregarFormaGeometrica(rectanguloBuilder);

                        break;
                    case (int)FormasGeometricas.TrianguloEquilatero:
                        var trianguloBuilder = new FormaBuilder(new TrianguloRectangulo { Base = item._base, Altura=item._altura });
                        var directorTriangulo = new DirectorForma();
                        directorTriangulo.ConstruirForma(trianguloBuilder);

                        totalizador.AgregarFormaGeometrica(trianguloBuilder);
                        break;
                    case (int)FormasGeometricas.Trapecio:
                        var trapecioBuilder = new FormaBuilder(new Trapecio { BaseMayor = item._baseMayor,BaseMenor=item._base,Altura=item._altura });
                        var directorTrapecio = new DirectorForma();
                        directorTrapecio.ConstruirForma(trapecioBuilder);

                        totalizador.AgregarFormaGeometrica(trapecioBuilder);
                        break;
                    default:
                        throw new NotImplementedException($"{Traduccion.FormaNoImplementadaAun}");
                }
            }
        }

        private static void SeleccionIdioma(int idioma)
        {
            switch (idioma)
            {
                case 2:
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
                    break;
                case 3:
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("it-IT");
                    break;
                default:
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("es-ES");
                    break;
            }
        }
    }
}
