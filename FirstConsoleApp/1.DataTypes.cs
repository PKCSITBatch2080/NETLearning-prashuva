
class DataTypes
{
   public void Learn(){
        // Numbers
        byte age = 255;
        byte dayOfWeek = 11;     //camelCase
        byte DayOfWeek = 1;   // pascal casing
        short b = 233;
        int c = 233;
        long d = 4746108;

        //Binary floating
        float f = 0.20f;

        //Decimal floating
        decimal d = 15.5m;

        //Boolean
        bool b = true;

        //Character
        char z = "P";

        //String: collection of characters
        string name = "John Doe";

        //Declare implicit variable
        var fruit = "Orange";
        var x = 10;

        //Array
        int[] roll = new int[];
        roll[0] = 14;
        string[] fruits = {"apple", "Banana", "Mango"};

        //Object
        DateTime date = DateTime.Now;
        Console.WriteLine(date);

       //Implicit conversion
       long num;
       num = c;

       //Explict conversion
       float int_to_float= (float)c;       
    }
}