using System;
var fullName = "Prashuva Dhital";
Console.WriteLine(fullName);

var cFullName = fullName.ToUpper();
Console.WriteLine($"Hello,{cFullName}!");

//Ask user to enter the name
Console.WriteLine("Please enter your full name:");
var FullName = Console.ReadLine();

CalculateAge a = new();
a.Age();