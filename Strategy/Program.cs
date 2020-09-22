using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            StreetRunner streetrunner = new StreetRunner();
            FormulaOne formulaone = new FormulaOne();
            Helicopter helicopter = new Helicopter();
            streetrunner.Go();
            formulaone.Go();
            helicopter.Go();
        }
    }
}
