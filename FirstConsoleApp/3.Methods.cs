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
}