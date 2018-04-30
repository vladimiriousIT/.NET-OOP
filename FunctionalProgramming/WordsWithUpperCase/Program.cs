using System;
using System.Linq;

namespace WordsWithUpperCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> checker = s => s[0].ToString() == s[0].ToString().ToUpper();
            var words = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).
                Where(checker)
                .ToList();
            // s => char.IsUpper(s[0])
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
            

        }
    }
}
