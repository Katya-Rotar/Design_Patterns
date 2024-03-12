using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Design_Patterns.Forge_of_heroes.Adapter
{
    public class WeightAdapter : IWeightAdapter
    {
        public double ConvertGramsToKilograms(double grams)
        {
            return grams / 1000.0;
        }
    }
}
