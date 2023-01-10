﻿using ConvertorLibs.ConversionObjects;
using ConvertorLibs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConvertorLibs.Services
{
    public abstract class ConvertorGenericService : IConvertorGenericService
    {
        public List<Conversion> Conversions = new List<Conversion>();
        private Conversion? CanConvert(string input1, string input2)
        {
            foreach (var conversion in Conversions)
            {
                bool fromFound = false;
                // Get all standardized formats for the source
                var fromNameList = conversion.FromType.ToLower().Split(',').ToList();
                if (fromNameList.Contains(input1)) fromFound = true;

                bool toFound = false;
                // Get all standardized formats for the source
                var toNameList = conversion.ToType.ToLower().Split(',').ToList();
                if (toNameList.Contains(input1)) toFound = true;

                // Return if both found in the same cycle
                if (fromFound && toFound) return conversion;
            }
            return null;
        }
        public string Convert(string from, string to)
        {
            try
            {
                var count = int.Parse(Regex.Match(from, @"\d+").Value);
                var conversionObj = CanConvert(from, to);
                if (conversionObj != null)
                {
                    return conversionObj.Convert(count);
                }
                // Inverse convert test
                var inverseConversionObj = CanConvert(to, from);
                if (inverseConversionObj != null)
                {
                    return inverseConversionObj.ConvertInverse(count);
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
