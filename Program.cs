using System;

namespace Questionnaire
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(">> Вводите слова, завершая каждое нажатием Enter");
            Console.WriteLine(">> Для выхода наберите \"exit\"");
            Console.WriteLine(">> Для выхода наберите \"exit\"");
            Console.WriteLine(">> Для выхода наберите \"exit\"");

            var word = "";
            var maxLength = 0;
            var theBiggestWord = word;
            do
            {
                Console.Write(">> ");
                word = Console.ReadLine();
                if (word.Length > maxLength)
                {
                    maxLength = word.Length;
                    theBiggestWord = word.ToUpper();
                }
            } while (word != "exit");
            Console.WriteLine(">>");
            Console.WriteLine(">> Считывание завершено");
            Console.WriteLine($"Самое длинное слово: {theBiggestWord} ({ theBiggestWord.Length}) ");
            Console.ReadKey();
        }
    }
}

