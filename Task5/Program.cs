namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double myDouble = 42.58;
            int myIntFromDouble = (int)myDouble;
            Console.WriteLine("The value of myDouble: " + myDouble);
            Console.WriteLine("The value of myIntFromDouble (cast from double): " + myIntFromDouble);
            int myInt = 42;
            double myDoubleFromInt = myInt;
            Console.WriteLine("The value of myInt: " + myInt);
            Console.WriteLine("The value of myDoubleFromInt (cast from int): " + myDoubleFromInt);
            int myIntForChar = 65;
            char myCharFromInt = (char)myIntForChar;
            Console.WriteLine("The value of myIntForChar: " + myIntForChar);
            Console.WriteLine("The value of myCharFromInt (cast from int): " + myCharFromInt);
            char myChar = 'A';
            int myIntFromChar = (int)myChar;
            Console.WriteLine("The value of myChar: " + myChar);
            Console.WriteLine("The value of myIntFromChar (cast from char): " + myIntFromChar);
        }
    }
}
    

