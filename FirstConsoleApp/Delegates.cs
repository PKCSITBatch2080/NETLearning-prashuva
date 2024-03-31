public delegate int Sum(int x, int y);
public delegate void PrintDel(int x);
public delegate void ReturnDel(string message);
class Delegates
{
    public static void CalculateSum()
    {
        Delegates D = new Delegates();
       /* Sum sum = new Sum(D.addition);
        int result = sum(10, 54);
        Console.WriteLine("Sum is = " + result);
        */

        // PrintDel print = new PrintDel(D.Print);
        // print.Invoke("Hello from C#");
        D.PrintHelper(100,D.PrintMoney );
        D.PrintHelper(20, D.PrintNumber);
        ReturnDel r = D.Demo();
        r("Hello");
    } 

    public int addition(int a, int b)
    {
        return a + b;
    }

    public void PrintMoney(int price)
    {
        Console.WriteLine("Price of ${0}", price);
    }

    public void PrintNumber(int num)
    {
        Console.WriteLine("Number is {0}", num);
    }

    public void PrintHelper(int x, PrintDel del)
    {
        del(x); 
    }
    public static void Print(string msg)
    {
        Console.WriteLine("Hello from C#");
    }
    public ReturnDel Demo()
    {
        return Print;
    }

}