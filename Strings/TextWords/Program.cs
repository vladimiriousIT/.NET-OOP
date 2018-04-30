using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextWordsCount
{
    class Program
    {
        static void Main()
        {
            var words = File.ReadAllText("words.txt").Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var text = File.ReadAllText("text.txt").ToLower();

            var result = new Dictionary<string, int>();

            foreach (var word in words)
            {
                var currentIndex = 0;
                var count = 0;
                
                while (true)
                {
                    var foundIndex = text.IndexOf(word, currentIndex);
                    if(foundIndex < 0)
                    {
                        break;
                    }

                    currentIndex = foundIndex + word.Length;
                    var privIndex = foundIndex - 1;

                    // is - Isabela 
                    if (privIndex > 0 && char.IsLetter(text[privIndex]))
                    {
                        continue;
                    }

                    var nextIndex = foundIndex + word.Length;
                    if (nextIndex < text.Length && char.IsLetter(text[nextIndex]))
                    {
                        continue;
                    }

                    count++;
                    
                }
                result[word] = count;
            }
            File.WriteAllText("odd-lines.txt", result.ToString());
        }
    }
}
