using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GodMorgen.Services
{
    public class CoffeeService
    {
        public static string Suggest(DateTime now)
        {
            int hour = now.Hour;

            if (hour < 11) return "How about a cappuccino? ☕";
            if (hour < 15) return "Americano to keep you focused?";
            if (hour < 19) return "Maybe a flat white?";
            return "It’s late — maybe decaf or tea?";
        }
    }
}