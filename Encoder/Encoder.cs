using System;

namespace Encoder
{
    public class EncoderProcessor
    {
        public string Encode(string message)
        {
          try
            {
                //"1. Vowels are replaced with number: a -> 1, e -> 2, i -> 3, o -> 4, and u -> 5 :  "
                Console.WriteLine("Output: " + ReplaceVowels(message));
                //"2. Consonants are replaced with previous letter: b -> a, c -> b, d -> c, etc. :  ";
                Console.WriteLine("Output: " + ReplacePreviousConsonent(message));
                //"3. Numbers are replaced with their reverse :  ";
                Console.WriteLine("Output: " + NumberReverse(message));
               //"4. All output should be lower case, regardless of input case ('Hello World' should produce the same result as 'hello world'): ";
                Console.WriteLine("Output: " + LowerCase(message));
                Console.ReadKey();
            }
            catch (global::System.Exception)
            {

                throw;
            }
        }
         public string ReplaceVowels(string message)
        {
            int count = 1;
            string output = string.Empty;
            var vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            List<int> numbers = new List<int>();
            foreach (var item in vowels)
            {
                int num = item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u' ? count : 0;
                count = count + 1;
                output = output + num + "";
            }
            return output;
        }
        public string ReplacePreviousConsonent(string message)
        {

            string output = string.Empty;
            string alphabet = "abcdefghijklomnopqrstuvwxyz";
            var alphbtArray = alphabet.ToCharArray();

            for (int i = 0; i < alphbtArray.Length - 1; i++)
            {
                if (alphbtArray[i] != 'a' || alphbtArray[i] != 'e' || alphbtArray[i] != 'i' || alphbtArray[i] != 'o' || alphbtArray[i] != 'u')
                {
                    string str = alphbtArray[i].ToString().Replace(alphbtArray[i], alphbtArray[i + 1]);
                    string editedStr = str + "-->" + alphbtArray[i] + " ,";
                    output = output + editedStr;
                }
            }

            return output;
        }
        public string NumberReverse(string message)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string output = string.Empty;
            string val = string.Empty;
            List<string> nums = new List<string>();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    val = numbers[j].ToString() + val;
                }
                nums.Add(val);
                val = string.Empty;
                output = string.Join(",", nums);

            }

            return output;
        }
        public string LowerCase(string message)
        {         
            return message.ToLower();
        }
    }
}
