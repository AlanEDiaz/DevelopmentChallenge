using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Models
{
    public class Cuadrado : Forma, IForma
    {
        public double Lado { get; set; }
    }
}
