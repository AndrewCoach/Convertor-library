using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertorLibs.Services
{
    public class PrefixService
    {
        public Dictionary<string, int> Prefixes { get; set; } = new Dictionary<string, int>();

        public PrefixService()
        {
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
