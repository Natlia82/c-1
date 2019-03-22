using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {  /******1***********/
            Console.WriteLine("Как вас зовут? ");
            string name = Console.ReadLine();
            Console.WriteLine("Ваша фамилия? ");
            string fam = Console.ReadLine();
            Console.WriteLine("cколько Вам лет? ");
            string year = Console.ReadLine();
            Console.WriteLine("Ваш рост? ");
            string rost = Console.ReadLine();
            Console.WriteLine("Ваш вес? ");
            string ves = Console.ReadLine();

            Console.WriteLine(name + " " + fam + " " + year + " " + rost + " " + ves);
            Console.WriteLine("{0} {1} {2} {3} {4} ", name, fam, year, rost, ves);
            Console.WriteLine($"{name} {fam} {year} {rost} {ves}");
            /***********2*******/
            Console.WriteLine("индекс массы тела: ");
            double ind = Convert.ToDouble(ves) / (Convert.ToDouble(rost)* Convert.ToDouble(rost));

            Console.WriteLine(Convert.ToString(ind));
            /************3**********/
            Console.WriteLine("расстояние между точками (x1 = 5, x2 = 20, y1 = 5, y2 = 20): ");
            Double x1 = 5;
            Double x2 = 20;
            Double y1 = 5;
            Double y2 = 20;

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("{0:F2}", r);
            /*******4*******/
            Console.WriteLine("обмен значениями двух переменных (a = 5, b = 1): ");
            int a = 5;
            int b = 1;
            int c;
            Console.WriteLine("с использованием третьей переменной: ");
            c = a;
            a = b;
            b = c;
            /****/
            Console.WriteLine("a = " + a + " b = " + b);
            Console.WriteLine("без использования третьей переменной: ");
          
            b = b + a;
            a = b - a;
            b = b - a;
            Console.WriteLine("a = " + a + " b = " + b);
            /**********5********/
            Console.WriteLine("Вагапова Наталья г.Оренбург");
            Console.SetCursorPosition(40, 25);
            Console.WriteLine("Вагапова Наталья г.Оренбург");

            Console.ReadLine();
        }
    }
}
