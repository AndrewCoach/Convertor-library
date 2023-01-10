using ConvertorLibs.ConversionObjects;
using ConvertorLibs.Interfaces;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConvertorLibs.Services
{
    /// <summary>A concrete implementation for Temperature metrics.</summary>
    public class TemperatureConvertorService : ConvertorGenericService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DistanceConvertorService" /> class.
        /// Define all conversion objects in this constructor. You can use a 
        /// comma delimited list of possible formats. The coefficient specifies by
        /// how much you must multiply the source unit to get the target unit.
        /// </summary>
        public TemperatureConvertorService()
        {
            Conversions.Add(new TemperaturesConversion { FromTypes = "celsius,c,cel", ToTypes = "fahrenheit,fa,f"});
            Conversions.Add(new TemperaturesConversion { FromTypes = "fahrenheit,fa,f", ToTypes = "kelvin,k"});
            Conversions.Add(new TemperaturesConversion { FromTypes = "kelvin,k", ToTypes = "celsius,c,cel" });
            // ...

        }
    }
}
