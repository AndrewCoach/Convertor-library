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
    /// <summary>A concrete implementation for Distance metrics such as meters, feet etc.</summary>
    public class DistanceConvertorService : ConvertorGenericService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DistanceConvertorService" /> class.
        /// Define all conversion objects in this constructor. You can use a 
        /// comma delimited list of possible formats without prefixes, 
        /// those are supported by default. The coefficient specifies by
        /// how much you must multiply the source unit to get the target unit. 
        /// So in the case of source=meter and target=kilometer, the coefficient would be 1000.
        /// </summary>
        public DistanceConvertorService()
        {
            Conversions.Add(new ConversionObjects.Conversion { Coefficient = 3, FromTypes = "meter,m,mtr", ToTypes = "foot,feet,ft"}); // the num 3 is a rought approximation because of tests
            Conversions.Add(new ConversionObjects.Conversion { Coefficient = 39.37, FromTypes = "meter,m,mtr", ToTypes = "inch,in,inches"});
            Conversions.Add(new ConversionObjects.Conversion { Coefficient = 0.028, FromTypes = "inch,in,inches", ToTypes = "yard,yrd,ya"});
            // ...

        }
    }
}
