using ConvertorLibs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertorLibs.ConversionObjects
{
    public class TemperaturesConversion : IConversion
    {
        /// The comma delimited string of possible formats of source unit without prefix, such as "F"
        public string FromTypes { get; set; }

        /// The comma delimited string of possible formats of target unit without prefix, such as "C"
        public string ToTypes { get; set; }


        /// <inheritdoc/>
        public string Convert(int amount, int prefix, int postfix)
        {
            // TODO: Temperature logic here
           return "";
        }

        /// <inheritdoc/>
        public string ConvertInverse(int amount, int prefix, int postfix)
        {
            // TODO: Temperature logic here
            return "";
        }
    }
}
