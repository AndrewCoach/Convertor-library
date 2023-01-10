using ConvertorLibs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertorLibs.Services
{
    public abstract class ConvertorGenericService : IConvertorGenericService
    {
        private List<IConversion> _conversions = new List<IConversion>();
        public abstract bool CanConvert(string input1, string input2);
        public abstract string Convert(string from, string to);
    }
}
