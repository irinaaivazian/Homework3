namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numericString = "12345";
            int parsedInt = int.Parse(numericString);
            string nonNumericString = "abc123";
            bool success = int.TryParse(nonNumericString, out int tryParsedInt);
            Console.WriteLine("The value of numericString: " + numericString);
            Console.WriteLine("The value after int.Parse: " + parsedInt);
            Console.WriteLine("The value of nonNumericString: " + nonNumericString);
            Console.WriteLine("The result of int.TryParse: " + success);
            if (success)
            {
                Console.WriteLine("The value after int.TryParse: " + tryParsedInt);
            }
            else
            {
                Console.WriteLine("int.TryParse failed to convert nonNumericString to an int.");
            }
        }
    }
}
