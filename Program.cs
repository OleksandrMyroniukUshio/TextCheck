using sharp28;
using System.Linq;
using System.Text.RegularExpressions;

namespace TextCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Run();
            }
            static void Run() {
                try {
                    Console.WriteLine("(Shouldn't contain >2000 symbols, in english alphabet and no special symbols)" +
                    "\nEnter the text: ");
                    string input = ReadText();
                    Validate(input);
                    Console.WriteLine($"Your input has {input.Length} symbols!");
                    Environment.Exit(0); // break operator didn't work well with try catch inside Run();
                }
                catch (Exception e) {
                    Console.WriteLine(e.ToString());
                }
            }
            static string ReadText() {
                string text = Console.ReadLine();
                if (System.IO.File.Exists(text)) text = File.ReadAllText(text);
                return text;
            }
            static void Validate(string text) {
                var regexItem = new Regex("^[a-zA-Z0-9 !\"#$%&'()*+,./:;<=>?@\\^_`{|}~-]*$");
                if (text.Length > 2000) throw new InvalidInputSizeException("Wrong input - text has more than 2000 symbols! \nTry to enter another text!");
                if (!regexItem.IsMatch(text)) throw new InvalidInputCharactersException("Wrong input - text has non-english alphabet or invalid symbols! \nTry to enter another text!");
            }
        }
    }
}