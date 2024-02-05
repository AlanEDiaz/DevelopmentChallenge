using DevelopmentChallenge.Data.Enum;
using DevelopmentChallenge.Data.Interfaces;
using DevelopmentChallenge.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class FormaBuilder : IFormaBuilder
    {
        public readonly Forma _forma;

        public FormaBuilder(Forma forma)
        {
            _forma = forma;
        }

        public void CalcularArea()
        {
            if (_forma is Circulo circulo)
            {
                _forma.Area = (Math.PI * Math.Pow(circulo.Radio, 2));
                _forma.FormaGeometrica = FormasGeometricas.Circulo;
            }
            else if (_forma is Cuadrado cuadrado)
            {
                _forma.Area = Math.Pow(cuadrado.Lado, 2);
                _forma.FormaGeometrica = FormasGeometricas.Cuadrado;

            }
            else if (_forma is TrianguloRectangulo triangulo)
            {
                _forma.Area = (triangulo.Base * triangulo.Altura) / 2;
                _forma.FormaGeometrica = FormasGeometricas.TrianguloEquilatero;

            }
            else if (_forma is Trapecio trapecio)
            {
                _forma.Area = ((trapecio.BaseMayor + trapecio.BaseMenor) * trapecio.Altura) / 2;
                _forma.FormaGeometrica = FormasGeometricas.Trapecio;

            }
            else if (_forma is Rectangulo rectangulo)
            {
                _forma.Area = rectangulo.LadoA * rectangulo.LadoB;
                _forma.FormaGeometrica = FormasGeometricas.Rectangulo;

            }
        }

        public void CalcularPerimetro()
        {
            if (_forma is Circulo circulo)
            {
                _forma.Perimetro = (2 * Math.PI * circulo.Radio);
            }
            else if (_forma is Cuadrado cuadrado)
            {
                _forma.Perimetro = 4 * cuadrado.Lado;
            }
            else if (_forma is TrianguloRectangulo triangulo)
            {
                _forma.Perimetro = triangulo.Base *3;
            }
            else if (_forma is Trapecio trapecio)
            {
                _forma.Perimetro = trapecio.BaseMayor + trapecio.BaseMenor + 2 * trapecio.Altura;
            }
            else if (_forma is Rectangulo rectangulo)
            {
                _forma.Perimetro = 2 * (rectangulo.LadoA + rectangulo.LadoB);
            }
        }
        public double ObtenerArea()
        {
            return _forma.Area;
        }

        public double ObtenerPerimetro()
        {
            return _forma.Perimetro;
        }
        public FormasGeometricas ObtenerTipo()
        {
            return _forma.FormaGeometrica;
        }
    }
}
