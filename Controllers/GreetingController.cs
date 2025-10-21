using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GodMorgen.Models;
using GodMorgen.Services;

namespace GodMorgen.Controllers
{
    public class GreetingController
    {
        public static void Run(string? rawName)
        {
            string name = (rawName ?? string.Empty).Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Invalid input: empty name.");
                return;
            }

            var employee = EmployeeService.FindByName(name);

            if (employee is null)
            {
                Console.WriteLine("Name not found in the system.");
                return;
            }

            Console.WriteLine($"Good morning, {employee.Name}! ({employee.Position})");

            if (!string.IsNullOrWhiteSpace(employee.MeetingTime))
            {
                Console.WriteLine($"Reminder: your meeting is at {employee.MeetingTime}.");
            }

            var coffee = CoffeeService.Suggest(DateTime.Now);
            Console.WriteLine(coffee);
        }
    }
}
