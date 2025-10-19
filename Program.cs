using System;
using GodMorgen.Controllers;

Console.WriteLine("Your name:");
string? name = Console.ReadLine();

GreetingController.Run(name);