The idea stays simple: greet someone at the door, remind them if they have a meeting, and offer a coffee that fits the time of day.

Here is the pseudocode I actually follow in my head when looking at this solution.

Start
Launch console app.
wire up controllers, services, and the in-memory database.

Program.cs
print "Your name: ".
wait for user to type name and press Enter.
forward that input to GreetingController.Run(name).

When user provides the name
rawName = text read from console.
if rawName is null -> treat as empty string.

Controllers/GreetingController.cs
name = trimmed version of rawName (empty string if null).
employee = EmployeeService.FindByName(name).
if employee is null
message = $"Hi {name}, I don't see you on the list."
coffee = CoffeeService.Suggest().
return JSON { greeting: message, coffee: coffee }.
else
greeting = $"Good morning {employee.Name}! ({employee.Position})".
meeting = employee.MeetingTime is set
? $"Reminder: meeting at {employee.MeetingTime}."
: "No meetings booked, enjoy the calm."
coffee = CoffeeService.Suggest().
return JSON { greeting, meeting, coffee }.

Data/EmployeeDatabase.cs
Employees = [
Employee("Joakim", "Manager", "10:00"),
Employee("Ivan", "Developer", "09:30"),
Employee("Jesper", "Designer", null),
Employee("Patrick", "HR", "11:15"),
Employee("Desiree", "Intern", "13:00")
].

Models/Employee.cs
class Employee
property Name : string (required).
property Position : string (required).
property MeetingTime : string? (optional).
constructor takes name, position, meetingTime.
assign values and keep as-is (no extra logic).

Services/EmployeeService.cs
method FindByName(inputName)
if inputName is empty -> return null.
comparer = case-insensitive string comparer.
for each employee in EmployeeDatabase.Employees
if comparer says employee.Name == inputName (after trimming)
return employee.
return null when loop ends.

Services/CoffeeService.cs
method Suggest(optional clock = DateTime.Now)
hour = clock.Hour.
if hour < 6 -> return "It's early, maybe grab some water first."
if hour < 11 -> return "How about a cappuccino?".
if hour < 15 -> return "Americano to keep you focused?".
if hour < 19 -> return "Maybe a flat white?".
else -> return "Herbal tea, start winding down.".

End
