using DevelopmentChallenge.Data.Enum;
using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Totalizador
    {
        public Dictionary<FormasGeometricas, int> contadorFormas = new Dictionary<FormasGeometricas, int>();
        public Dictionary<FormasGeometricas, double> totalAreas = new Dictionary<FormasGeometricas, double>();
        public Dictionary<FormasGeometricas, double> totalPerimetros = new Dictionary<FormasGeometricas, double>();
        public double totalGeneralArea = 0;
        public double totalGeneralPerimetro = 0;
        public double totalFiguras = 0;


        public void AgregarFormaGeometrica(IFormaBuilder builder)
        {
            FormasGeometricas tipo = builder.ObtenerTipo();

            if (contadorFormas.ContainsKey(tipo))
            {
                contadorFormas[tipo]++;
                totalAreas[tipo] += builder.ObtenerArea();
                totalPerimetros[tipo] += builder.ObtenerPerimetro();

                totalGeneralArea += totalAreas[tipo];
                totalGeneralPerimetro += totalPerimetros[tipo];
                totalFiguras++;

            }
            else
            {
                contadorFormas.Add(tipo, 1);
                totalAreas.Add(tipo, builder.ObtenerArea());
                totalPerimetros.Add(tipo, builder.ObtenerPerimetro());

                totalGeneralArea += totalAreas[tipo];
                totalGeneralPerimetro += totalPerimetros[tipo];
                totalFiguras++;

            }
        }

    }
}
