using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace GB_5._2
{  /*

         // Сиваченко Егор Александрович
        д) ***Создать метод, который производит частотный анализ текста. 
        В качестве параметра в него передается массив слов и текст, 
        в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.
        Здесь требуется использовать класс Dictionary.
  */
    static class Message
    {
        static string[] GetSplittedArray(string str)
        {
            return str.Split(new char[] { ' ', '.', ',', '!', ';', '\'' }, StringSplitOptions.RemoveEmptyEntries);
        }
        static int GetMaxLength(string input)
        {
            int length = 0;
            string[] subs = GetSplittedArray(input);
            foreach (var sub in subs)
            {
                if (sub.Length > length)
                    length = sub.Length;
            }

            return length;
        }
        static public string PrintByWordsLength(string input, int count)
        {
            string output = String.Empty;
            string[] subs = GetSplittedArray(input);
            foreach (var sub in subs)
            {
                if (sub.Length <= count)
                    output += $"{sub} ";
            }

            return output;
        }
        static public string RemoveByChar(string input, char chr)
        {
            string output = String.Empty;
            string[] subs = GetSplittedArray(input);
            foreach (var sub in subs)
            {
                if (sub[sub.Length - 1] != chr)
                    output += $"{sub} ";
            }

            return output;
        }
        static public string GetMaxLengthWord(string input)
        {
            string output = String.Empty;
            string[] subs = GetSplittedArray(input);
            foreach (var sub in subs)
            {
                if (sub.Length > output.Length)
                    output = sub;
            }

            return output;
        }
        static public string GetMaxLengthWords(string input)
        {
            StringBuilder a = new();
            string[] subs = GetSplittedArray(input);
            foreach (var sub in subs)
            {
                if (sub.Length == GetMaxLength(input))
                    a.Append(sub + ' ');

            }

            return a.ToString();
        }
        static public Dictionary<string, int> GetWordsFrequency(string[] wordsArr, string input)
        {
            string temp_string = String.Empty;
            Dictionary<string, int> wordsFrequency = new();

            string[] subs = GetSplittedArray(input);
            

            for (int i = 0; i < wordsArr.Length; i++)
            {

                foreach (var sub in subs)
                {
                    if (sub.ToLower() == wordsArr[i])
                    {
                        if (wordsFrequency.ContainsKey(sub))
                            wordsFrequency[sub]++;
                        else
                            wordsFrequency.Add(sub.ToLower(), 1);
                    }

                }


            }
               
            
            return wordsFrequency;

        }


    }
}
