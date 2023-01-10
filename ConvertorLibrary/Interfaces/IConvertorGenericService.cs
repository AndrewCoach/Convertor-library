using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertorLibs.Interfaces
{
    /// <summary>Interface to expose the convert method for different types of units. 
    /// Implementations can define different Conversion objects for their needs.</summary>
    internal interface IConvertorGenericService
    {
        /// <summary>Converts the specified unit with the amount to the target unit. Both can have a prefix</summary>
        /// <param name="from">The source unit with or without a prefix and with an amount, commonly something like "5 millimeters"</param>
        /// <param name="to">The target unit with an optional prefix. Commonly similar to "kilometer".</param>
        /// <returns>The output number with the target unit string</returns>
        string Convert(string from, string to);

        /// <summary>Determines whether this instance can convert the specified input1 into input2.</summary>
        /// <param name="input1">The input1.</param>
        /// <param name="input2">The input2.</param>
        /// <returns>
        ///   <c>true</c> if this instance can convert the specified input1; otherwise, <c>false</c>.</returns>
        bool CanConvert(string input1, string input2);
    }
}
