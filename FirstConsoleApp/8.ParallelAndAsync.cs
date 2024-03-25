using System;
using System.Threading.Tasks;
public class ParallelAndAsync
{
    // Parallel Programming
    // Tasks - takes CPU time and independent
    int[] numbers = [3234, 5643, 8745, 9865, 1235, 98316, 76532];

    private void CalculateSquare(int n)
    {
        var square = n * n;
        Console.WriteLine($"Square of {n} is {square}");
        Thread.Sleep(1000);
    }


    //Sequential
    public void ProcessNumbers()
    {
        Console.WriteLine("Sequential loop:");
        foreach(var num in numbers)
        {
            CalculateSquare(num);
        }
    }

    //Parallel
    public void ProcessNumbersParallel()
    {
         Console.WriteLine("Parallel loop:");
         //TPL - Task Parallel Library
         Parallel.ForEach(numbers, CalculateSquare);
    }

    //Asynchronous Programming - async, await
    public async Task MakeTea()
    {
        await IgniteStove();
        await BoilWaterOnTeaPot();
        await PrepareMasala();
        await AddIngrediants();

    }
    private async Task IgniteStove()
    {
        await Task.Delay(1000);
    }
    private async Task<bool> BoilWaterOnTeaPot()
    {
        return false;
    }

    private async Task PrepareMasala()
    {

    }

    private async Task AddIngrediants()
    {

    }


}