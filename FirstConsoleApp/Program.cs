using System;


Console.WriteLine("I am main method");
DataTypes dt = new();
dt.Learn();

Methods m = new();
m.Greet();
m.Greet("Namaste");
m.CalculateBMI(65f, 5.4f );
double MaxNumber = m.GetMax(3.5, 4.6, 7.8, 8.9);
Console.WriteLine(MaxNumber);

Generics g = new();
g.Display<string>("dsghasui");
g.Display<int>(342);

Student prashuva = new Student();
Student devi = new Student("Devi", 114);
devi.RollNumber = 34 //Assigned
devi.RollNumber = 134 // Not Assigned

