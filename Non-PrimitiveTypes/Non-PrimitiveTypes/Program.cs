using System;

namespace Non_PrimitiveTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var names = new string[3] {"Jack", "John", "Mary"};
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);

            var firstName = "Jason";
            var lastName = "Comstock";

            var fullName = firstName + " " + lastName;

            var myFullNmae = string.Format("My name is {0} {1}", firstName, lastName);

            var newNames = new string[3] { "Jim", "Elaine", "Jerry"};
            var formattedNames = string.Join(",", newNames);
            Console.WriteLine(formattedNames);

            var text = @"Hi Jim
Look into the following paths
c:\folder1\folder2
c:\folder3\folder4";
            Console.WriteLine(text);
        }
    }
}
