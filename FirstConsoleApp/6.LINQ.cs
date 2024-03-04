//LINQ = Language Integrated Query
using System.Linq;

class LINQLearner
{
    void Learn()
    {
        int[] numbers = [3, 4, 7, 8, 12, 13, 22, 45];
        List<string> names = ["Seema", "Rima", "Sapana", "Sangya", "Sabeena","Prashuva"];

        var s1 = new Student("Prashuva", 30, new DateTime(2002, 04, 05));
        var s2 = new Student("Sangya", 35, new DateTime(2003, 05, 05));
        var s3 = new Student("Prita", 24, new DateTime(2002, 04, 17));
        var s4 = new Student("Sabeena", 13, new DateTime(2003, 07, 07));
        var s5 = new Student("Shyam", 31, new DateTime(2002, 04, 14));
        
        List<Student> students =[s1, s2, s3, s4, s5];

        //Get odd number from "numbers"
        var oddNumbers = numbers.Where(number => number % 2 == 1); //Lambda Expression
        Console.WriteLine(oddNumbers);

        //Get squares of all items in "numbers"
        var squares = numbers.Select(x => x * x);

        //Get squares of even numbers only
        //Method Squares
        var evenSquares = numbers.Where(numbers => numbers % 2 == 0).Select(x => x * x);

        //Query Syntax
        evenSquares = from x in numbers 
                        where x % 2 == 0 
                        select x * x;

       //Get all names initials
       var initails = names.Select(name => name[0]); //['S', 'R', 'S','S', 'S', 'P']

       //Order names in ascending order
       var namesOrdered = names.OrderBy(x => x);

       //Find students with name starting with "P"
       var PStudents = students.Where(student => student.name.ToLower().StartsWith('p'));

       //Group students by birth month
       var birthMonths = students.GroupBy(Student => Student.dob.Month);

       //Get youngest student
       var youngest = students.OrderByDescending(x => x.dob).First();
       youngest = students.MaxBy(x => x.dob);
    }
}
