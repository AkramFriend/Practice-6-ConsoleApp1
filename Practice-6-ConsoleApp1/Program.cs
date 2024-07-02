using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_6_ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter("practice-6", true, Encoding.Unicode))
            {
                char key = 'д';
                while (char.ToLower(key) == 'д')
                {
                    string note = string.Empty;
                    Console.Write("ID: ");
                    note += $"{Console.ReadLine()}\t";
                    string now = DateTime.Now.ToShortTimeString();
                    Console.WriteLine($"Время заметки: {now}");
                    note += $"{now}\t";
                    Console.Write("ФИО: ");
                    note += $"{Console.ReadLine()}\t";
                    Console.Write("Возраст: ");
                    note += $"{Console.ReadLine()}\t";
                    Console.Write("Рост: ");
                    note += $"{Console.ReadLine()}\t";
                    Console.Write("Дата рождения: ");
                    note += $"{Console.ReadLine()}\t";
                    Console.Write("Место рождения: ");
                    note += $"{Console.ReadLine()}\t"; 
                    sw.WriteLine(note);
                    Console.Write("Продолжить д/н: "); key = Console.ReadKey(true).KeyChar;
                }
            }
        }
    }
}
