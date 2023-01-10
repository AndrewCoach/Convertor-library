using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertorLibs.Interfaces
{
    internal interface IConversion
    {
        (string, string) GetTypes();

        string Convert(string from, string to);
    }
}
