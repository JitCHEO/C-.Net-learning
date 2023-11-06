

using BethanysPieShopHRM;

Console.WriteLine("Creating an employee");
Console.WriteLine("--------------------\n");

Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25, EmployeeType.Manager);
Employee george = new("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30, EmployeeType.Research);

// // Demo: Custom Types(need to import JSON)
// string.bethanyAsJson = bethany.ConvertToJson();
// Console.WriteLine(bethanyAsJson);

// Demo: Strings are Reference Types
// string name = "bethany";
// string anotherName = name;
// name += " smith";

// Console.WriteLine("Name: " + name);
// Console.WriteLine("Another name: " + anotherName);

// string upperCaseName = name.ToUpper();

// Console.WriteLine("Name: " + name);
// Console.WriteLine("Uppercase name: " + upperCaseName);

// // Strings BUILDERS
// Alot better in term of memory use
// StringBuilder builder = new StringBuilder();
// builder.Append("Last name: ");
// builder.AppendLine(lastName);
// builder.Append("First name: ");
// builder.Append(firstName);
// string result = builder.ToString();

// // 
// bethany.DisplayEmployeeDetails();

// bethany.PerformWork();
// bethany.PerformWork();
// bethany.PerformWork(5);
// bethany.PerformWork();

// // double receivedWageBethany = bethany.ReceiveWage(true);
// // Console.WriteLine($"Wage paid (message from Program): {receivedWageBethany}");

// // //bethany.firstName = "John";
// //bethany.hourlyRate = 10;

// bethany.DisplayEmployeeDetails();
// bethany.PerformWork();
// bethany.PerformWork(12);
// bethany.PerformWork();
// bethany.ReceiveWage();

// Console.WriteLine("Creating an employee");
// Console.WriteLine("--------------------\n");

// george.DisplayEmployeeDetails();
// george.PerformWork();
// george.PerformWork();
// george.PerformWork(3);
// george.PerformWork();
// george.PerformWork(8);

// var receivedWageGeorge = george.ReceiveWage(true);

// // // Demo: Working with Value & Reference Type
// int a = 42;
// int aCopy = a;
// aCopy = 100;
// Console.WriteLine($"Value of a: {a} and value of copy of a: {aCopy}");

// Employee testEmployee = bethany;
// testEmployee.firstName = "Gill";

// testEmployee.DisplayEmployeeDetails();
// bethany.DisplayEmployeeDetails();


// Demo: Passing Parameters by Value & by Reference
// bethany.PerformWork(25);

// int minimumBonus = 100;
// int receivedBonus = bethany.CalculateBonus(minimumBonus);
// Console.WriteLine($"The minimum bonus is {minimumBonus} and {bethany.firstName} has received a bonus of {receivedBonus}");


// int minimumBonus = 100;
// int bonusTax = 0;
// int receivedBonus = bethany.CalculateBonusAndBonusTax(minimumBonus, ref bonusTax);
// Console.WriteLine($"The minimum bonus is {minimumBonus}, the bonus tax is {bonusTax} and {bethany.firstName} has received a bonus of {receivedBonus }");


// Demo: Using Out
// int minimumBonus = 100;
// int bonusTax;
// int receivedBonus = bethany.CalculateBonusAndBonusTax(minimumBonus, out bonusTax);
// Console.WriteLine($"The minimum bonus is {minimumBonus}, the bonus tax is {bonusTax} and {bethany.firstName} has received a bonus of {receivedBonus }");


WorkTask task;
task.description = "Bake delicious pies";
task.hours = 3;
task.PerformWorkTask();
