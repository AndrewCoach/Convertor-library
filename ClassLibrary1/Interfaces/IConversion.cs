using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertorLibs.Interfaces
{
    /// <summary>An interface defining a basic conversion unit that converts a 
    /// defined number of units to different units. Units can have 
    /// common defined prefixes such as "milli" "micro" and so on.</summary>
    public interface IConversion
    {

        /// <summary>Converts the specified amount of units into different units with prefixes.</summary>
        /// <param name="amount">The amount.</param>
        /// <param name="prefix">The prefix of the source unit.</param>
        /// <param name="postfix">The prefix of the second "target" unit.</param>
        /// <returns>The result in string format</returns>
        string Convert(int amount, int prefix, int postfix);

        /// <summary>Converts the specified amount of units in reverse order.</summary>
        /// <param name="amount">The amount.</param>
        /// <param name="prefix">The prefix of the source unit.</param>
        /// <param name="postfix">The prefix of the second "target" unit.</param>
        /// <returns>The result in string format</returns>
        string ConvertInverse(int amount, int prefix, int postfix);
    }
}
