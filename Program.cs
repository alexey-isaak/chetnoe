using System;
 
namespace chetnoe
{
    class Program
    {
        static void Main()
        {
Console.Write("Ведите число: ");
int a = int.Parse(Console.ReadLine());
double x = a % 2;
if ( x == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}
      }
       }
}
