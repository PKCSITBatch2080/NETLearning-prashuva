using System.Linq;
class Methods
{
   public void Greet()
        {
            Console.WriteLine("Hey, there!");
        }
   public void Greet(string greeting)
   {
        Console.WriteLine($"{greeting}, there");  //string interpolation
    }   

   public float CalculateBMI(float weightINKg, float heightInFt )
   {
    var heightInM = heightInFt * 0.3048f;
    var bmi = weightINKg / (heightInM* heightInM);
    return bmi;
    } 

//  variable number of argument
    public double GetMax( params double[] numbers) => numbers.Max();

    public (int, int) GetMinMax(params int[] numbers){
        var smallest = numbers.Min();
        var largest = numbers.Max();
        return (smallest, largest);
        
    }
}