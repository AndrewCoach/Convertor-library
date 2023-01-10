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
    public class DistanceConvertorService : ConvertorGenericService
    {
        public DistanceConvertorService()
        {
            Conversions.Add(new ConversionObjects.Conversion { Coefficient = 3, FromType = "meter,m,mtr", ToType = "foot,feet,ft"});
        }

    }
}
