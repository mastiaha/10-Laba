using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Laba
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Мурка", "черный",1);
            cat.Say();
            
            //Cat cat = new Cat("Мурка", "черный", 1);
            //cat.Say();
            //Console.WriteLine(cat.color);
            Console.ReadKey();
        }
    }

    class Cat
    {
        public string Name { get; set; }
        public string Color { get; set; }
        int age;

        //public Cat(string name, string color = "Серый", int age = -1)
        //{
        //    this.name = name;
        //    this.color = color;
        //    this.age = age;
        //}

        public int Age
        {
            set
            {
                if (value > 0)
                {
                    age = value;
                }

                else
                {
                    Console.WriteLine("Возраст не может быть отрицательным");
                }
            }
            get
            {
                return age;
            }
        }
        

        //public void SetAge (int age)
        //{
        //    if (age > 0)
        //        this.age = age;
        //}
        //public int GetAge ()
        //{
        //    return age;
        //}
        public Cat(string name, string color, int age)
        {
            Name = name;
            Color = color;
            Age = age;
        }
        public void Say()
        {
            Console.WriteLine("Мяу. Меня зовут {0}. У меня {1} цвет. Мне {2} лет", Name, Color, Age);
        }
    }
}
