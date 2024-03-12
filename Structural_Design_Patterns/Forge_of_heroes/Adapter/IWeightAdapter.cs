using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Design_Patterns.Forge_of_heroes.Adapter
{
    public interface IWeightAdapter
    {
        double ConvertGramsToKilograms(double grams);
    }
}
