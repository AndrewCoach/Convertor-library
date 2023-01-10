using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertorLibs.Interfaces
{
    internal interface IConversion
    {
        returnTypes GetTypes();

        string Convert(int amount);

        string ConvertInverse(int amount);
    }

    public class returnTypes
    {
        public string FromType { get; set; }

        public string ToType { get; set; }
    }
}
