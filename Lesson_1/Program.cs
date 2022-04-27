using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя: ");
            string strFio;
            strFio = Console.ReadLine();
            DateTime dt = DateTime.Now;
            Console.WriteLine("Привет, {0}, сегодня {1}",strFio,dt);
            Console.ReadKey();
        }
    }
}
