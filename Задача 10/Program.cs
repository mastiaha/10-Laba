using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Ugol ugol = new Ugol(5, 95, 99);
            ugol.Gradus();
            ugol.ToRadians();

            Console.ReadKey();
        }
    }

    class Ugol
    {
        int grad { get; set; }
        int min { get; set; }
        int sec { get; set; }

       
        public int Grad
        {
            set
            {
                grad = value;
            }
            get
            {
                return grad;
            }
        }
        public int Min
        {
            set
            {
                min = value % 60;
                grad += value / 60;
            }
            get
            {
                return min;
            }
        }
        public int Sec
        {
            set
            {
                sec = (value % 60) % 60;
                min += value / 60;
            }
            get
            {
                return sec;
            }
        }

        public Ugol(int grad, int min, int sec)
        {
            Grad = grad;
            Min = min;
            Sec = sec;
        }
        public void Gradus()
        {
            Console.WriteLine("Дан угол {0} градусов {1} минут {2} секунд", Grad, Min, Sec);
        }
        public void ToRadians()
        {
            double Radians = (grad + min / 60 + sec / 360) * (Math.PI) / 180;
            Console.WriteLine("В радианах соответственно {0} рад", Radians);
        }
        
    }
}
