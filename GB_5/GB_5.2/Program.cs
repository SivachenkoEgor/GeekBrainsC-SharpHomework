using System;

namespace GB_5._2
{
    class Program
    {
        /*
         * 2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
        а) Вывести только те слова сообщения, которые содержат не более n букв.
        б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
        в) Найти самое длинное слово сообщения.
        г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
        д) ***Создать метод, который производит частотный анализ текста. 
        В качестве параметра в него передается массив слов и текст, 
        в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.
        Здесь требуется использовать класс Dictionary.
         */

        static void Main(string[] args)
        {
            void Exercise_Shower()
            {
                string text = "Всем привет! I'd like to say, that i love you all. Byebye!";
                string[] arr = { "i", "all", "привет" };
                Console.WriteLine(Message.PrintByWordsLength(text, 4));
                Console.WriteLine(Message.RemoveByChar(text, 'e'));
                Console.WriteLine(Message.GetMaxLengthWord(text));
                Console.WriteLine(Message.GetMaxLengthWords(text));
                foreach (var pair in Message.GetWordsFrequency(arr, text))
                {
                    Console.WriteLine($"key: {pair.Key}  value: {pair.Value}");
                }
            }

            Exercise_Shower();
        }
    }
}
