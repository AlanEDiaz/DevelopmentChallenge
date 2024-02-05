using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Models
{
    public class Trapecio : Forma, IForma
    {
        public double BaseMayor { get; set; }
        public double BaseMenor { get; set; }
        public double Altura { get; set; }
    }
}
