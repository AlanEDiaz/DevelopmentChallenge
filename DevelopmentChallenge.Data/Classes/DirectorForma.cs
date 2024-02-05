using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class DirectorForma
    {
        private IFormaBuilder builder;
        public void ConstruirForma(IFormaBuilder builder)
        {
            builder.CalcularArea();
            builder.CalcularPerimetro();
        }
    }
}
