
using System;
using System.Runtime.InteropServices;

namespace ДЗ.Циклы_освоение
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int beforLaunch;
            Console.Write(" Установите отщет до запуска ракеты: ");
            beforLaunch = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Запуск произойдет через: ");

            while (beforLaunch-->0)
            {
                Console.WriteLine(beforLaunch);
            }
        }
    }
}
