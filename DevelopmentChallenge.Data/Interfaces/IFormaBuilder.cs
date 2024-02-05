using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Interfaces
{
    public interface IFormaBuilder
    {
        void CalcularArea();
        void CalcularPerimetro();
        double ObtenerArea();
        double ObtenerPerimetro();
        FormasGeometricas ObtenerTipo();
    }
}
