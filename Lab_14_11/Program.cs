using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            try
            {
                int n;
                Console.Write("Выберете животное, узнайте, что оно говорит:\n  1   Кот\n  2   Собака\n  Ваш выбор: ");
                n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        {
                            Cat cat = new Cat();
                            cat.ShowInfo();
                            break;
                        }
                    case 2:
                        {
                            Dog dog = new Dog();
                            dog.ShowInfo();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Нет операции с указанным номером");
                            break;
                        }
                }

            }
            catch
            {
                Console.WriteLine("Ошибка! Входная строка имела неверный формат");
            }
            Console.ReadKey();
        }
    }
    public abstract class Animal
    {
        public abstract string Name { get; set; }
        public Animal()
        {
        }
        public abstract string Say();
        public virtual void ShowInfo()
        {
            Console.Write(Name);
            Console.WriteLine(Say());
        }
    }
    public class Cat : Animal
    {

        public string name = "Кот";
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public override string Say()
        {
            return " говорит \"Мяу\"";
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
        }
    }
    public class Dog : Animal
    {

        public string name = "Собака";
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public override string Say()
        {
            return " говорит \"Гав\"";
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
        }
    }
}
