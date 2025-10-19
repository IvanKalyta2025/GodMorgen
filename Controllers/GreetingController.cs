using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GodMorgen.Controllers
{
    public class GreetingController
    {
        public static void Run(string? rawName)
        {
            string name = (rawName ?? string.Empty).Trim();
        }
    }
}