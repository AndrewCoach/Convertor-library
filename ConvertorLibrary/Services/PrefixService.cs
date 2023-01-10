using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertorLibs.Services
{
    /// <summary>A Simple service to wrap a dictionary of predefined prefixes with their respective powers</summary>
    public class PrefixService
    {
        /// <summary>The Dictionary containing the prefixes.</summary>
        /// <value>The prefixes Dictionary</value>
        public Dictionary<string, int> Prefixes { get; set; } = new Dictionary<string, int>();

        public PrefixService()
        {
            Prefixes.Add("centi", -2);
            Prefixes.Add("milli", -3);
            Prefixes.Add("micro", -6);
            Prefixes.Add("nano", -9);
            Prefixes.Add("pico", -12);
            // ...
            Prefixes.Add("kilo", 3);
            Prefixes.Add("mega", 6);
            Prefixes.Add("giga", 9);
            Prefixes.Add("tera", 12);
            // ...
        }
    }
}
