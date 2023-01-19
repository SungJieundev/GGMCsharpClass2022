using System;

namespace basic_221112
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Area(a: 2, b: 3));
            //printP("성지은");

            //Console.WriteLine(Add(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            //Console.WriteLine(Sub(float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine())));
           

            int Add(int a, int b)
            {
                return a + b;
            }
            float Sub(float a, float b)
            {
                return a - b;
            }

            //DateClass cDay = new DateClass();
            //cDay.year = 2022;
            //cDay.month = 11;
            //cDay.day = 12;

            //Console.WriteLine($"{cDay.year}.{cDay.month}.{cDay.day}");

            //DateClass cDay2 = new DateClass();
            //Console.WriteLine($"{cDay2.year}.{cDay2.month}.{cDay2.day}");

            Animal myDog = new Animal("멍멍이", 3, "강아지");
            Animal myCat = new Animal();

            myDog.Walk();
            myDog.Eat();
            myCat.Walk();
            myCat.Eat();

            new ClassA();
            new ClassA();
            new ClassB();
            new ClassB();

            Console.WriteLine(Global.count);
        }

        public static class Global
        {
            public static int count = 0;
        }

        class ClassA
        {
            public ClassA()
            {
                Global.count++;
            }
        }

        class ClassB
        {
            public ClassB()
            {
                Global.count++;
            }
        }

        public class Animal
        {
            public string name;
            public int age;
            public string speices;

            public Animal()
            {
                name = "키티";
                age = 5;
                speices = "고양이";
            }
            public Animal(string name, int age, string speices)
            {
                this.name = name;
                this.age = age;
                this.speices = speices;
            }

            public void Walk()
            {
                Console.WriteLine($"{name}가 걷습니다");
            }

            public void Eat()
            {
                Console.WriteLine($"{name}가 먹습니다");
            }
        }

        public class DateClass
        {
            public int year;
            public int month;
            public int day;
        }

        static int Area(int a, int b)
        {
            return a * b;
        }

        //선택적 매개변수
        static void printP(string name, string phone = "")
        {
            Console.WriteLine($"이름: {name} 전화번호: {phone}");
        }
    }

    
}
