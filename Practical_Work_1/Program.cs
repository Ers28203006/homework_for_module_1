using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Work_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*------- Написать приложение, которое выведет на экран Ваше имя и фамилию -------*/

            Console.Write("Меня зовут ");
            Console.WriteLine("Ерсын Султанбаев");

            /*------- Написать приложение, которое ожидает ввода нескольких чисел и выводит на экран их сумму -------*/

            int n = 5, number, summa=0;
            for (int i=0; i<n; i++)
            {
                Console.Write("Введите число: ");
                number = int.Parse(Console.ReadLine());
                summa += number;
            }

            Console.Write("Cумма введенных чисел: ");
            Console.WriteLine(summa);

            Console.ReadLine();
        }
    }
}
