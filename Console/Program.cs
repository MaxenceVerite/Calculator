using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorEngine engine = new CalculatorEngine();
            int resultat = engine.Add(5, 2);
        }
    }
}
