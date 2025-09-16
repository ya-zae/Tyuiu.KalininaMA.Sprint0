// See https://aka.ms/new-console-template for more information

using Tyuiu.KalininaMA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KalininaMA.Sprint0.Task2.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.GetMessage("Мария"));
            Console.ReadKey();
        }
    }
}