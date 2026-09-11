using Tyuiu.SologubNV.Sprint0.Task5.V0.Lib;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        WriteLine("A + B = " + DataService.Addition(1, 5));
        WriteLine("A - B = " + DataService.Subtraction(15, 5));
        WriteLine("A * B = " + DataService.Multiplication(10, 10));
        WriteLine("A / B = " + DataService.Division(9, 3));
        ReadKey();

    }
}