using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace extension_method_homeWork
{
    public static class StringExtension {  // класс расширения
     public static string CaesarEncrypt(this string input, int shift)
    {
        string result = "";
        foreach (char c in input)
        {
                if (c >= (int)'A' && c <= (int)'Z')
                {
                    char newChar = (char)(((int)c + shift - 65) % 26 + 65);
                    result += newChar;
                }
                else if (c >= (int)'a' && c <= (int)'z')
                {
                    char newChar = (char)(((int)c + shift - 97) % 26 + 97);
                    result += newChar;
                }
                else if (c >= (int)'А' && c <= (int)'Я') // шифрование для кириллицы
                {
                    char newChar = (char)(((int)c + shift - 1040) % 32 + 1040);
                    result += newChar;
                }
                else if (c >= (int)'а' && c <= (int)'я') // шифрование для кириллицы
                {
                    char newChar = (char)(((int)c + shift - 1072) % 32 + 1072);
                    result += newChar;
                }
            }
        return result;
    }

    public static string CaesarDecrypt(this string input, int shift)
    {
        string result = "";
        foreach (char c in input)
        {
                if (c >= (int)'A' && c <= (int)'Z')
                {
                    char newChar = (char)(((int)c - shift - 65 + 26) % 26 + 65);
                    result += newChar;
                }          
                else if (c >= (int)'a' && c <= (int)'z')
                {
                    char newChar = (char)(((int)c - shift - 97 + 26) % 26 + 97);
                    result += newChar;
                }
                else if (c >= (int)'А' && c <= (int)'Я')
                {
                    char newChar = (char)(((int)c - shift - 1040 + 32) % 32 + 1040);
                    result += newChar;
                }
                else if (c >= (int)'а' && c <= (int)'я') // шифрование для кириллицы
                {
                    char newChar = (char)(((int)c - shift - 1072 + 32) % 32 + 1072);
                    result += newChar;
                }
            }
        return result;
    }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово для шифра");
            string word = Console.ReadLine(); // считали строку
            Console.WriteLine($"Слово для шифра: {word}");

            int shiftNumber;
            do
            {
                Console.WriteLine("Введите цифра для шифрования от 1 до 26");
                shiftNumber = int.Parse(Console.ReadLine()); // считали число
                Console.WriteLine($"Вы ввели число {shiftNumber}");
            } while (shiftNumber < 1 || shiftNumber > 26 ); // зациклили ввод

            Console.WriteLine($"Слово с зашифровкой - {word.CaesarEncrypt(shiftNumber)}"); // сделали вывод 
            string newWord = word.CaesarEncrypt(shiftNumber);
            Console.WriteLine($"Слово с расшифровкой - {newWord.CaesarDecrypt(shiftNumber)}");






            Console.ReadLine();
        }
    }
}
