using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertorLibs.Interfaces
{
    public interface IConversion
    {

        string Convert(int amount);

        string ConvertInverse(int amount);
    }
}
