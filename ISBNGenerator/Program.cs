using System;

namespace ISBNGenerator
{
    public class Program
    {
        private const int HeaderLength = 3;

        public static void Main(string[] args)
        {
            string userInputProductId = GetUserInput();

            ValidateUserInput(userInputProductId);

            string strippedHeaderInput = userInputProductId.Substring(HeaderLength, userInputProductId.Length - HeaderLength);

            IIsbnBuilder builder = new IsbnBuilder();
            string isbn = builder.GenerateIsbn(strippedHeaderInput);

            Console.WriteLine($"Generated ISBN: {isbn}");
        }

        private static void ValidateUserInput(string userInputProductId)
        {
            if (userInputProductId.Length != 12)
            {
                Console.Error.WriteLine("ERROR: Entered product ID is not the correct length");
                ExitProgram();
            }
            if (userInputProductId.Substring(0, 3) != "978")
            {
                Console.Error.WriteLine("ERROR: Product ID does not contain the correct header sequence");
                ExitProgram();
            }

            long userInputInt;
            if (!long.TryParse(userInputProductId, out userInputInt))
            {
                Console.Error.WriteLine("ERROR: Product ID may only contain numerals");
                ExitProgram();
            }
        }

        private static string GetUserInput()
        {
            Console.WriteLine("A Product ID is a 12 digit, numerical sequence that starts with '978'");
            Console.Write("Please enter a valid Product ID: ");

            string productId = Console.ReadLine();
            Console.WriteLine("\n");

            return productId;
        }

        private static void ExitProgram()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
