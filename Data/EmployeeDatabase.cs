using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GodMorgen.Models;
namespace GodMorgen.Data
{
    public static class EmployeeDatabase
    {
        public static readonly List<Employee> Employees =
[
        new Employee("Joakim", "Manager", "10:00"),
        new Employee("Ivan", "Developer", "09:30"),
        new Employee("Lars", "Designer", null),
        new Employee("Patrick", "HR", "11:15"),
        new Employee("Desiree", "Intern", "13:00")
];
    }
}