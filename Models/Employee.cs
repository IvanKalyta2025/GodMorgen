using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GodMorgen.Models
{
    public class Employee
    {
        public string Name { get; }
        public string Position { get; }
        public string? MeetingTime { get; }

        public Employee(string name, string position, string? meetingTime)
        {
            Name = name;
            Position = position;
            MeetingTime = meetingTime;
        }
    }

}