The idea.

The program accepts the user's name.

The program checks the name against the employee database.

The program greets the user and reminds them of a meeting based on their position.

The user is offered coffee based on the time.

pseudocode

Start

Program.cs

Write Your name:

        Enter name

Controllers/GreetingController.cs
string rawName
string name = (rawName ?? string.Empty).Trim();

Data/EmployeeDatabase.cs

list
new Employee("Joakim", "Manager", "10:00"),
new Employee("Ivan", "Developer", "09:30"),
new Employee("Jesper", "Designer", null),
new Employee("Patrick", "HR", "11:15"),
new Employee("Desiree", "Intern", "13:00")

Models/Employee.cs

START Employee Class

    property Name  (text)
    property Position  (text)
    property MeetingTime  (optional text)

    WHEN creating a new Employee (constructor):
        SET Name = given name
        SET Position = given position
        SET MeetingTime = given meeting time (can be empty or null)

END Employee Class

Services/CoffeeService.cs

Services/EmployeeService.cs

readme.md
