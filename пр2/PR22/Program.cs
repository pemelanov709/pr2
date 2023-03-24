using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR22
{
    class Cezar
    {
        private static string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяabcdefghijklmnopqrstuvwxyz";

        public static string encryption(string chars)
        {
            var res = new StringBuilder();
            for (int i = 0; i < chars.Length; i++)
                for (int j = 0; j < alphabet.Length; j++)
                    if (chars[i] == alphabet[j]) res.Append(alphabet[(j + 3) % alphabet.Length]);

            return res.ToString();
        }
        public static string decryption(string cryptchars)
        {
            var res = new StringBuilder();
            for (int i = 0; i < cryptchars.Length; i++)
                for (int j = 0; j < alphabet.Length; j++)
                    if (cryptchars[i] == alphabet[j]) res.Append(alphabet[(j - 3 + alphabet.Length) % alphabet.Length]);

            return res.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Приветствие
            Console.Write("\nШифровка/Дешифровка Цезеря" +
                "\nВведите(Д/Ш):");
            char chs = char.Parse(Console.ReadLine());

            //Выбор действия
            if(chs == 'Ш')
            {
                //Шифрование
                Console.Write("Введите ваше послание: ");
                string txt = Console.ReadLine();
                Console.WriteLine(Cezar.encryption(txt));
            }
            else if (chs == 'Д')
            {
                //Расшифровка
                Console.Write("Введите ваш шифер : ");
                string crypt = Console.ReadLine();
                Console.WriteLine(Cezar.decryption(crypt));
            }
            else
            {
                Environment.Exit(0);
            }

            Console.ReadKey(true);
        }
    }
}
