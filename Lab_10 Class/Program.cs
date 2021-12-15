using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Угол задан с помощью целочисленных значений gradus - градусов, min - угловых минут, sec - угловых секунд. 
 * Реализовать класс, в котором указанные значения представлены в виде свойств. 
 * Для свойств предусмотреть проверку корректности данных. 
 *Класс должен содержать конструктор для установки начальных значений,
 * а также метод ToRadians для перевода угла в радианы. 
 *Создать объект на основе разработанного класса. 
 * Осуществить использование объекта в программе.*/
namespace Lab_10_Class
{
    class Gradus
    {
        //Присваиваем значение полям в члену классса Trans
        int grad;
        int min;
        int sec;

        public int Grad
        {
            set
            {
                if (value >= 0 && value <= 360) grad = value;
                else Console.WriteLine("Градусы вне диапазона");
            }
            get { return grad; }
        }
        public int Min
        {
            set
            {
                if (value >= 0 && value <= 60) min = value;
                else Console.WriteLine("Минуты вне диапазона");
            }
            get { return min; }
        }
        public int Sec
        {
            set
            {
                if (value >= 0 && value <= 60) sec = value;
                else Console.WriteLine("Секунды вне диапазона");
            }
            get { return sec; }
        }
        public double ToRadian()
        {
            double decGrad = grad + min / 60 + sec / 3600;
            double radian = decGrad * (3.14 / 180);
            return radian;
        }

        //Параметризированный конструктор для классса.
        public Gradus(int grad, int min, int sec)
        {
            Grad = grad;
            Min = min;
            Sec = sec;
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Введите градусы в диапазоне от 0 до 360");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите минуты в диапазоне от 0 до 60");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите секунды в диапазоне от 0 до 60");
                int c = Convert.ToInt32(Console.ReadLine());
                Gradus gradus = new Gradus(a, b, c);
                double radian = gradus.ToRadian();
                Console.WriteLine("Число {0}.{1}.{2} равно {3:F5} радиан", a, b, c, radian);
                Console.ReadKey();
            }
        }
    }
}
