using System.Diagnostics.CodeAnalysis;

namespace RefFieldsVariables
{
    ref struct Wine
    {
        public ref int AgeInYears;

        public Wine(ref int age)
        {
            AgeInYears = ref age;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            int age = 10;

            Wine wine = new Wine(ref age);
            ref int localAge = ref wine.AgeInYears;

            Console.WriteLine($"Age of wine is {localAge}");

            Console.ReadLine();
        }
    }
}
