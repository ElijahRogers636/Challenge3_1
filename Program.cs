namespace Challenge3_1
{
    internal class Program
    {
        // Given a string, write a method that checks if it is a palindrome (is read the same backward as forward). Assume that string may consist only of lower-case letters.
        static void Main(string[] args)
        {
            Console.WriteLine("Palindrome Detector");
            Console.WriteLine("Enter a word or phrase. If the input is a palindrome the result will be True, or if not, False");
            Console.Write("Here: ");
            string word = Console.ReadLine();

            string result = PalindromeDetector(word).ToString();

            Console.WriteLine();
            Console.WriteLine($"Result: {result}");
        }

        // Test to see if input param is a palindrome.
        static bool PalindromeDetector(string word)
        {
            word = word.Replace(" ", "").Replace(".","").Replace(",","").ToLower();
            bool result = false;
            for (int i = 0; i < word.Length; i++)
            {
                if(word[i] == word[(word.Length - 1)- i])
                {
                    result = true;
                }
                else
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
    }
}
