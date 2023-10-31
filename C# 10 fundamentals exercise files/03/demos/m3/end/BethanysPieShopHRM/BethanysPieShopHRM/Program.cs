// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


// Working with Built-In types
Console.WriteLine("Welcome to Bethany's Pie Shop HRM");
//Console.WriteLine("Enter your name:");

//The following will accept the name
//string name = Console.ReadLine();

/*
    Here are some tests around working with valid identifiers in C#
    We can write here as much as we want, this is all comment
*/

//string name2 = Console.ReadLine();
//string name_2 = Console.ReadLine();
//string Name_2 = Console.ReadLine();

//string 2name = Console.ReadLine();

// Demo: Working with Primitive Type
// Demo: Using var
var monthlyWage = 1234;
int months = 12, bonus = 1000;


bool isActive = true;
double rating = 99.25;
var rating = 99.25;
var numberOfEmployees = 300; // hover mouse over numberOfEmployees will tell u that it is int(integer)
// byte numberOfEmployees = 300; (This is not going to work because byte ie between 0 & 255)

int hoursWorked;

hoursWorked = 125;

hoursWorked = 148;

//monthlyWage = true; (cannot change the type, becuase at the above is integer and cant assign is true, 
//  is type safety, once variable declare, cannot change it type)


const double interestRate = 0.07;
// interestRate = 0.08;


string firstName = "Bethany";
string lastName = "Smith";

string emptyString = "";

string s;

s = firstName;

// Demo: Using operator in C#
double ratePerHour = 12.34;
int numberOfHoursWorked = 165;

double currentMonthWage = ratePerHour * numberOfHoursWorked + bonus;
Console.WriteLine(currentMonthWage);

ratePerHour += 3; // ratePerHour = ratePerHour + 3;
Console.WriteLine(ratePerHour);

if (currentMonthWage > 2000)
    Console.WriteLine("Top paid employee");

int numberOfEmployees = 15;
numberOfEmployees--; // ++
Console.WriteLine(numberOfEmployees);

// Demo: Working with Members on Promitive Type
int intMaxValue = int.MaxValue;
int intMinValue = int.MinValue;

// Members of char Types
// dotnet run do not show this section
char userSelection = 'a';
char upperVersion = char.ToUpper(userSelection);
bool isDigit = char.IsDigit(userSelection);
bool isLetter = char.IsLetter(userSelection);


// Demo: Working with DateTime
DateTime hireDate = new DateTime(2022, 3, 28, 14, 30, 0);
// DateTime hireDate = new DateTime();
Console.WriteLine(hireDate);

DateTime exitDate = new DateTime(2025, 12, 11);

//DateTime invalidDate = new DateTime(2025, 15, 11);

DateTime startDate = hireDate.AddDays(15);
Console.WriteLine(startDate);

var currentDate = DateTime.Now;
bool areWeInDst = currentDate.IsDaylightSavingTime();

DateTime startHour = DateTime.Now;
TimeSpan workTime = new TimeSpan(8, 35, 0);
DateTime endHour = startHour.Add(workTime);

Console.WriteLine(startHour);
Console.WriteLine(endHour);

Console.WriteLine(startHour.ToLongDateString());
Console.WriteLine(endHour.ToShortTimeString());

// Demo: Converting between types
long veryLongMonth = numberOfHoursWorked;//works fine!

double d = 123456789.0;
int x = (int)d;

int intVeryLongMonth = (int)veryLongMonth;//might fail

Console.ReadLine();
