using ConvertorLibs.ConversionObjects;
using ConvertorLibs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConvertorLibs.Services
{
    /// <summary>This abstract class serves for the specific 
    /// implementations of Converter classes.</summary>
    public abstract class ConvertorGenericService : IConvertorGenericService
    {

        /// <summary>The list containing all defined conversions. 
        /// These should be defined in a constructor of an inheriting class.</summary>
        public List<Conversion> Conversions = new List<Conversion>();

        /// <summary>The private prefix service
        /// to parse prefixes into Powers</summary>
        private PrefixService prefixService = new PrefixService();

        /// <inheritdoc/>
        public bool CanConvert(string input1, string input2)
        {
            return canConvert(input1, input2) != null;
        }

        private Conversion? canConvert(string input1, string input2)
        {
            foreach (var conversion in Conversions)
            {
                bool fromFound = false;
                bool toFound = false;

                // Get all standardized formats for the source
                var fromNameList = conversion.FromTypes.ToLower().Split(',').ToList();
                if (fromNameList.Contains(input1)) fromFound = true;

                // Get all standardized formats for the source
                var toNameList = conversion.ToTypes.ToLower().Split(',').ToList();
                if (toNameList.Contains(input2)) toFound = true;

                // Return if both found in the same cycle
                if (fromFound && toFound) return conversion;
            }

            return null;
        }

        /// <inheritdoc/>
        public string Convert(string from, string to)
        {
            try
            {
                // Parse the count and text from the first parameter
                var count = int.Parse(Regex.Match(from, @"\d+").Value); // get just the number
                var onlyText = Regex.Replace(from, @"[\d-] ", string.Empty); // get just text

                int prefix = 0;
                int postfix = 0;
                // Get prefixes for the units, if they contain them
                foreach (var pair in prefixService.Prefixes)
                {
                    if (onlyText.StartsWith(pair.Key))
                    {
                        // remove prefix form the text + initialize the Power number
                        prefix = pair.Value;
                        onlyText = onlyText.Replace(pair.Key, "");
                    }
                        
                    if (to.StartsWith(pair.Key))
                    {
                        postfix = pair.Value;
                        to = to.Replace(pair.Key, "");
                    }
                }

                // Test if we can convert
                var conversionObj = canConvert(onlyText, to);
                if (conversionObj != null)
                {
                    // Convert number with prefixes and return with the original unit
                    return conversionObj.Convert(count, prefix, postfix) + $" {to}";
                }
                // Inverse convert test
                var inverseConversionObj = canConvert(to, onlyText);
                if (inverseConversionObj != null)
                {
                    // Use the service to do an inverse conversion
                    return inverseConversionObj.ConvertInverse(count, prefix, postfix) + $" {to}"; ;
                }

                return $"No suitable conversion was found for inputs {from} and {to}";
            } 
            catch(Exception ex)
            {
                return $"The conversion failed! Error message : {ex.Message}";
            }
        }
    }
}
