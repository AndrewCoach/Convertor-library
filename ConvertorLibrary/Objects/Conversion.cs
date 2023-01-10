using ConvertorLibs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertorLibs.ConversionObjects
{
    public class Conversion : IConversion
    {
        /// The comma delimited string of possible formats of source unit without prefix, such as "meter"
        public string FromTypes { get; set; }

        /// The comma delimited string of possible formats of target unit without prefix, such as "foot"
        public string ToTypes { get; set; }

        /// The coefficient that specifies the conversion, or by how much must we multiply one source unit to get one target unit"
        public double Coefficient { get; set; }

        /// <inheritdoc/>
        public string Convert(int amount, int prefix, int postfix)
        {
           return $"{((amount * Math.Pow(10, prefix)) * Coefficient) / Math.Pow(10, postfix)}";
        }

        /// <inheritdoc/>
        public string ConvertInverse(int amount, int prefix, int postfix)
        {
            try
            {
                return $"{((amount * Math.Pow(10, prefix)) / Coefficient) * Math.Pow(10, postfix)}"; // Division by zero failsafe
            }
            catch (DivideByZeroException ex)
            {
                return ex.Message;
            }
        }
    }
}
