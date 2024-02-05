using DevelopmentChallenge.Data.Enum;
using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public abstract class Forma
    {
        public double Area { get; set; }
        public double Perimetro { get; set; }
        public FormasGeometricas FormaGeometrica { get; set; }
    }
}
