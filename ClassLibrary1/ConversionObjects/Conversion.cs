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
        public  string FromType { get; set; }
        public  string ToType { get; set; }
        public  double Coefficient { get; set; }

        public string Convert(int amount)
        {
           return $"{amount * Coefficient}";
        }

        public string ConvertInverse(int amount)
        {
            try
            {
                return $"{amount / Coefficient}"; // Division by zero failsafe
            }
            catch (DivideByZeroException ex)
            {
                return ex.Message;
            }
        }
    }
}
