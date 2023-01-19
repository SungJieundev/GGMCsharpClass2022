using System;
using MyCar;

namespace basic_221001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car(10108, "나의 자동차", 1);

            string prime = string.Format("10 이하의 소수는 {0}, {1}, {2}, {3}입니다.", 2 , 3, 5, 7);

            Console.WriteLine(prime);

            int i = 123;

            object o = i;

            i += 10;

            int j = (int)o;

            Console.WriteLine($"{i}, {o}, {j}");

            o = 100;

            //Console.WriteLine($"{o} ,{p}");



            const int MAXINT = int.MaxValue;
            const int MININT = int.MinValue;

            Console.WriteLine(MAXINT);
            Console.WriteLine(MININT);


            //MAXINT = 5;
            //MININT = 10;

            //byte b = 







        }
    }  
}


namespace MyCar
{
    class Car
    {
        public int id;
        public int oil;
        public string name;

        public Car(int id, string name, int oil)
        {
            this.id = id;
            this.name = name;
            this.oil = oil;

            Ride();
        }

        public void Ride()
        {
            Console.WriteLine($"{id} : {name}인 차가 굴러갑니다. 기름은 {oil} 리터 만큼 남았습니다.");
        }
    }
}
