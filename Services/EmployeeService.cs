using System;
using System.Globalization;
using System.Linq;
using GodMorgen.Data;
using GodMorgen.Models;

namespace GodMorgen.Services
{
    public static class EmployeeService
    {
        public static Employee? FindByName(string name)
        {
            var cmp = StringComparer.Create(CultureInfo.InvariantCulture, ignoreCase: true);
            return EmployeeDatabase.Employees
                .FirstOrDefault(e => cmp.Equals(e.Name.Trim(), name.Trim()));
        }
    }
}
