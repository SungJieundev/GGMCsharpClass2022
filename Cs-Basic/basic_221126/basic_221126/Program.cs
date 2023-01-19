using System;

namespace basic_221126
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 2; i < 100; i++)
            {   
                IsPrime(i);
                if (IsPrime(i) == true)
                {
                    sum++;
                }
            }

            Console.WriteLine(sum.ToString());

            Rectangle rect1 = new Rectangle(1, 2);
            Rectangle rect2 = new Rectangle(3, 3);
            Rectangle rect3 = new Rectangle(2, 5);

            Console.WriteLine(rect1.calcArea());
            Console.WriteLine(rect1.isSquare());

            Console.WriteLine(rect2.calcArea());
            Console.WriteLine(rect2.isSquare());

            Console.WriteLine(rect3.calcArea());
            Console.WriteLine(rect3.isSquare());

            Rectangle.printCount();

            Person.Show();

            Person person = new Person();
            person.Print();

            Person person1 = new Person(20);
            person1.Print();
        }

        public static int sum = 0;
        static bool IsPrime(int a)
        {
            for(int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }

            return true; 
        }
    }

    class MyClass
    {
        public int myField1;
        public int myField2;

        public void DeepCopy()
        {
            
        }
    }

    class Person
    {
        public static string name;
        public int age;

        static Person()
        {
            name = "홍길동";
        }
        public Person()
        {
            age = 17;
        }
        public Person(int a)
        {
            age = a;
        }

        public static void Show()
        {
            Console.WriteLine(name);
        }
        public void Print()
        {
            Console.WriteLine(age);
        }

    }

    class Rectangle
    {
        static int count = 0;

        int width = 1;
        int height = 1;

        public Rectangle(int wid, int hei)
        {
            width = wid;
            height = hei;

            count++;
        }

        public int calcArea()
        {
            return width * height;
        }

        public bool isSquare()
        {
            if(width == height)
            {
                return true;
            }
            return false;
        }

        public static void printCount()
        {
            Console.WriteLine(count);
        }
    }
}
