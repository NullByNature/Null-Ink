using System;
using System.IO;

namespace NullInk
{
    class Program
    {
        static void Main()
        {
            Program program = new Program();
            Console.WriteLine("Enter the text that you want to blur:");
            string text = Console.ReadLine();
            // make sure text is not null
            while (string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Text can not be blank");
                text = Console.ReadLine();
            }
            program.Blur_text(text);
        }

        void Blur_text(string text)
        {
            string blurred = "";
            foreach (char c in text)
            {
               if (char.IsLetter(c))
                {
                    blurred += "*";
                }
               else
                {
                    blurred += c;
                }
            }
            Console.WriteLine($"Blurred text: {blurred}");
        }
    }
}