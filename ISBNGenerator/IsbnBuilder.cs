using System.Collections.Generic;

namespace ISBNGenerator
{
    public class IsbnBuilder : IIsbnBuilder
    {
        // last index is always weight 1
        private static readonly List<int> IndexWeights = new List<int>() { 10, 9, 8, 7, 6, 5, 4, 3, 2 };

        private static int ModulusValue { get; } = 11;

        public string GenerateIsbn(string productId)
        {
            var errorDigitCode = GenerateErrorDigitCode(productId);

            return BuildCompleteIsbn(productId, errorDigitCode);
        }

        private static int GenerateErrorDigitCode(string productId)
        {
            int nineDigitSum = GenerateNineDigitSum(productId);
            if (nineDigitSum % ModulusValue == 0)
            {
                return 0;
            }

            int nextDivisibleValue = GetNextNumberDivisibleByValue(nineDigitSum, ModulusValue);

            int errorDigitCode = nextDivisibleValue - nineDigitSum;
            return errorDigitCode;
        }

        private static int GenerateNineDigitSum(string productId)
        {
            int sum = 0;
            int index = 0;
            foreach (char c in productId)
            {
                var val = (int)char.GetNumericValue(c) * IndexWeights[index];
                sum = sum + val;
                index++;
            }

            return sum;
        }

        private static int GetNextNumberDivisibleByValue(int currentSum, int value)
        {
            return (currentSum / value + 1) * value;
        }

        private static string BuildCompleteIsbn(string productId, int errorDigitCode)
        {
            string completeIsbn;

            if (errorDigitCode == 10)
            {
                completeIsbn = productId + "X";
                return completeIsbn;
            }

            completeIsbn = productId + errorDigitCode;
            return completeIsbn;
        }

    }
}
