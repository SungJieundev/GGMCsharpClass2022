using System;

namespace basic_221015
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region var
            //var a = 30;
            //var b = 3.141592;
            //var c = "Hello World";
            //var d = new int[] { 15, 25, 35 };

            //Console.WriteLine($"a의 타입은 {a.GetType()}, 값은 {a}");
            //Console.WriteLine($"b의 타입은 {b.GetType()}, 값은 {b}");
            //Console.WriteLine($"c의 타입은 {c.GetType()}, 값은 {c}");
            //Console.WriteLine($"d의 타입은 {d.GetType()}, 값은 ");

            //for (int i = 0; i < 3; i++)
            //{
               // Console.WriteLine(d[i]);
            //}
            #endregion

            #region

            int v1 = 100;
            float v2 = 1.234f;
            string st = "성지은";

            Console.WriteLine(v1.ToString() + "," + v2.ToString() + "," + st);
            //Console.WriteLine("v1 = {0}, v2 = {1}, st = {3}", v1, v2, st);
            Console.WriteLine($"v1 = {v1}, v2 = {v2}, st = {st}");

            #endregion

            #region
            //Console.WriteLine("{0:N2}", 1234.5678);
            //Console.WriteLine("{0:D8}", 1234);
            //Console.WriteLine("{0:F3}", 1234.56);

            //int a = int.Parse(Console.ReadLine()) + int.Parse(Console.ReadLine());
            //Console.WriteLine(a.ToString());
            //int b = int.Parse(Console.ReadLine()) - int.Parse(Console.ReadLine());
            //Console.WriteLine(b.ToString());
            //int c = int.Parse(Console.ReadLine()) * int.Parse(Console.ReadLine());
            //Console.WriteLine(c.ToString());
            //int d = int.Parse(Console.ReadLine()) / int.Parse(Console.ReadLine());
            //Console.WriteLine(d.ToString());
            #endregion

            #region

            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine(a++);
            //Console.WriteLine(++a);

            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine(b--);
            //Console.WriteLine(--b);
            #endregion

            #region 관계연산자
            //int int1 = int.Parse(Console.ReadLine());
            //int int2 = int.Parse(Console.ReadLine());

            //bool result = int1 == int2;
            //Console.WriteLine($"{int1} == {int2} : {result}");

            //result = int1 > int2;
            //Console.WriteLine($"{int1} > {int2} : {result}");

            //result = int1 > int2;
            //Console.WriteLine($"{int1} < {int2} : {result}");

            //result = int1 >= int2;
            //Console.WriteLine($"{int1} >= {int2} : {result}");
            #endregion

            #region 논리연산자

            //Console.WriteLine("Testing &&...");

            //bool a = 1 > 0 && 4 < 5;
            //bool b = 1 > 0 && 4 > 5;
            //bool c = 1 == 0 && 4 > 5;
            //bool d = 1 == 0 && 4 < 5;

            //Console.WriteLine($"1 > 0 && 4 < 5 : {a}");
            //Console.WriteLine($"1 > 0 && 4 > 5 : {b}");
            //Console.WriteLine($"1 == 0 && 4 > 5 : {c}");
            //Console.WriteLine($"1 == 0 && 4 < 5 : {d}");

            //Console.WriteLine();

            //Console.WriteLine("Testing ||...");

            //bool a1 = 1 > 0 || 4 < 5;
            //bool b1 = 1 > 0 || 4 > 5;
            //bool c1 = 1 == 0 || 4 > 5;
            //bool d1 = 1 == 0 || 4 < 5;

            //Console.WriteLine($"1 > 0 || 4 < 5 : {a1}");
            //Console.WriteLine($"1 > 0 || 4 > 5 : {b1}");
            //Console.WriteLine($"1 == 0 || 4 > 5 : {c1}");
            //Console.WriteLine($"1 == 0 || 4 < 5 : {d1}");

            //Console.WriteLine();

            //Console.WriteLine("Testing !...");
            //Console.WriteLine($"!true : {!true}");
            //Console.WriteLine($"!false : {!false}");

            #endregion

            #region 조건연산자
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine(input >= 0 ? "양수입니다" : "음수입니다");

            Console.WriteLine(input % 2 == 0 ? "짝수" : "홀수");

            for(int i = 0; i < input; i++)
            {
                Console.WriteLine((input % 10 == 0) ? $"{i}\n" : $"{i}");
            }
            Console.WriteLine();
            #endregion
        }
    }
}
