using System;

namespace basic_221008
{
    internal class Program
    {

        enum DialogResult { YES=10, NO, CANCEL, CONFIRM, OK=50 }

        enum Size { Short, Tall, Grande, Venti}

        static int[] price = new int[] { 3300, 3800, 4300, 4800 };

        enum Colors { Red = 1, Green = 2, Blue = 4, Yellow = 8};
        enum Coffee { Short = 3300, Tall = 3800, Grande = 4300, Venti = 4800}
        static void Main(string[] args)
        {
            int x = int.MaxValue;
            int y = x + 10;

            Console.WriteLine(x);
            Console.WriteLine(y);

            int?[] arr = new int?[5] { 1, 2, 3, 4, null };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].HasValue);

                switch (arr[i])
                {
                    case null:
                        arr[i] = 0;
                        break;
                    default:
                        arr[i] += 1;
                        break;
                    
                }

            }
                for(int j = 0; j < arr.Length; j++)
                {
                    Console.WriteLine(arr[j]);
                }

            #region enum2
            foreach (Coffee coffee in Enum.GetValues(typeof(Coffee)))
            {
                Console.WriteLine(coffee);
            }

            foreach(Size size in Enum.GetValues(typeof(Size)))
            {
                Console.WriteLine(size);
                Console.WriteLine((int)size);
            }

            foreach(Colors colors in Enum.GetValues(typeof(Colors)))
            {
                Console.WriteLine(colors);
            }
            #endregion
            #region enum1
            foreach (DialogResult item in Enum.GetValues(typeof(DialogResult)))
            {

                Console.WriteLine(item.ToString());
            }

            foreach (DialogResult item in Enum.GetValues(typeof(DialogResult)))
            {
                Console.WriteLine((int)item);
            }

            Random rand = new Random();

            DialogResult result = (DialogResult)rand.Next(0, 5);

            switch (result)
            {
                case DialogResult.YES:
                    Console.WriteLine("예 입니다");
                    break;
                case DialogResult.NO:
                    Console.WriteLine("아니오 입니다");
                    break;
                case DialogResult.CANCEL:
                    Console.WriteLine("취소 입니다");
                    break;
                case DialogResult.CONFIRM:
                    Console.WriteLine("확인 입니다");
                    break;
                case DialogResult.OK:
                    Console.WriteLine("오케이 입니다");
                    break;
            }
            #endregion
        }
    }
}
