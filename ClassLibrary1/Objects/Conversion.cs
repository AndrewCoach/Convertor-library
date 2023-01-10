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
        public  string FromTypes { get; set; }
        public  string ToTypes { get; set; }
        public  double Coefficient { get; set; }

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
