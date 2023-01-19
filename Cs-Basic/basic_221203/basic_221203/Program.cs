using System;

namespace basic_221203
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Employee emp2 = new Employee("지은", "고등학생");

            emp.SetName("성지은");
            emp.SetPosition("학생");

            Console.WriteLine(emp.GetName());
            Console.WriteLine(emp.GetPosition());

            Console.WriteLine(emp2.GetName());
            Console.WriteLine(emp2.GetPosition());



            MyClass myClass = new MyClass();
            myClass.PrintFields();

            Console.WriteLine();

            MyClass myClass2 = new MyClass(1);
            myClass2.PrintFields();

            Console.WriteLine();

            MyClass myClass3 = new MyClass(10, 20);
            myClass3.PrintFields();



            Base ba = new Base("a");
            Derived de = new Derived("b");

            ba.BaseMethod();
            de.BaseMethod();
            de.DerivedMethod();



            Mammal mammal = new Dog();

            Dog dog = new Dog();

            if(dog is Dog)
            {
                dog = mammal as Dog;
                dog.Bark();
            }

            Mammal mammal2 = new Cat();
            Cat cat = mammal as Cat; ;

            cat?.Meow();

            Cat cat2 = mammal as Cat;

            if (cat2 != null) cat2.Meow();
            else Console.WriteLine("cat2는 Cat 형식이 아닙니다");
            
        }
    }

    class Mammal
    {
        public void Nurse()
        {
            Console.WriteLine("Nurse()");
        }
    }

    class Dog : Mammal
    {
        public void Bark()
        {
            Console.WriteLine("Bark");
        }
    }

    class Cat : Mammal
    {
        public void Meow()
        {
            Console.WriteLine("Meow");
        }
    }

    class Base
    {
        public string Name;

        public Base(string Name)
        {
            this.Name = Name;
            Console.WriteLine($"{this.Name}.Base");

        }

        public void BaseMethod()
        {
            Console.WriteLine($"{this.Name}.BaseMethod");
        }
    }

    class Derived : Base
    {
        public Derived(string Name) : base(Name)
        {
            Console.WriteLine($"{Name}.Derived");
        }
        
        public void DerivedMethod()
        {
            Console.WriteLine($"{Name}.DerivedMethod()");
        }
    }

    class MyClass
    {
        int a, b, c;

        public MyClass()
        {
            a = 314;
            Console.WriteLine("MyClass()");

        }

        public MyClass(int b) : this()
        {
            this.b = b;
            Console.WriteLine("MyClass(b)");
        }

        public MyClass(int b,int c) : this(b)
        {
            this.c = c;
            Console.WriteLine("MyClass(b,c)");
        }

        public void PrintFields()
        {
            Console.WriteLine($"{a}, {b}, {c}");
        }
    }

    class Employee
    {
        private string Name;
        private string Position;

        public Employee()
        {

        }

        public Employee(string Name, string Position)
        {
            this.Name = Name;
            this.Position = Position;
        }

        public void SetName(string Name)
        {
           this.Name = Name;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetPosition(string Position)
        {
            this.Position = Position;
        }

        public string GetPosition()
        {
            return Position;
        }
    }
}
