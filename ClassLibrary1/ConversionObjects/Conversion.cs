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
        private readonly string _fromType;
        private readonly string _toType;
        private readonly double _coefficient;

        public Conversion(string fromType, string toType, double coefficient)
        {
            _fromType = fromType;
            _toType = toType;
            _coefficient = coefficient;
        }

        public string Convert(int amount)
        {
           return $"{amount * _coefficient} {_toType}";
        }

        public string ConvertInverse(int amount)
        {
            try
            {
                return $"{amount / _coefficient} {_toType}"; // Division by zero failsafe
            }
            catch (DivideByZeroException ex)
            {
                return ex.Message;
            }
        }

        public returnTypes GetTypes()
        {
            return new returnTypes { FromType = _fromType, ToType = _toType };
        }
    }
}
