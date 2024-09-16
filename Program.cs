using System.Diagnostics;

namespace Topic_2_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Joshua F
            Console.WriteLine("I was born in " + (2024 - 16) + ".");
            Console.WriteLine();
            Console.WriteLine("The average of 15, 16, 17, is, " + ((15.0 + 16.0 + 17.0) / 3));
            Console.WriteLine();
            Console.WriteLine("The average of 15, 16, 17, 18, is, " + ((15.0 + 16.0 + 17.0 + 18.0) / 4));
            Console.WriteLine();
            Console.WriteLine("The area of a circle is A = pi*r^2");
            Console.WriteLine("We have been given a radius of 3 centimetres");
            Console.WriteLine("Let's calculate the area of the circle");
            Console.WriteLine(Math.Round(Math.PI * (3*3), 1));
            Console.WriteLine();
            Console.WriteLine("C# only adds numbers if there are two of them together, but not if the + operator is in quotations");
            Console.WriteLine("For example, C# won't add if I do (15 + 16) in quotations, but will add if I put them outside of quotations");
            Console.WriteLine(15 + 16);
            Console.WriteLine("as you can see, no quotations, it just added");
            Console.WriteLine("During a quotation though, the + operator will only add if the mathematical equation is in brackets.");
            Console.ReadLine();
        }
    }
}
