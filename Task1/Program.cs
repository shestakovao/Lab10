using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Angle angle;
            do
            {
                Console.WriteLine("Введите угол в градусах минутах секундах:");
                int gradus = Convert.ToInt32(Console.ReadLine());
                int min = Convert.ToInt32(Console.ReadLine());
                int sec = Convert.ToInt32(Console.ReadLine());
                angle = new Angle(gradus, min, sec);
            } while (angle.isCorrect == false);

            double toRadian = angle.ToRadians();
            Console.WriteLine("Угол в радианах = {0:f3}",toRadian);
            Console.ReadKey();
        }
    }
}
