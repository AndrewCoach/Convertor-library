using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertorLibs.Interfaces
{
    internal interface IConvertorGenericService
    {
        bool CanConvert(string input1, string input2);

        string Convert(string from, string to);
    }
}
