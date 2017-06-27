using System;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            EXM1();
            //EXM2();
            //EXM3();
            //EXM4();

            Console.ReadKey();
        }


        static void EXM1()
        {
            int x = 0;
            do
            {
                Console.WriteLine(x);
                x++;
            } while (x < 10);
        }

        static void EXM2()
        {
            int i = 0;
            do
            {
                Console.WriteLine("Value of i: {0}", i);
                i++;
                if (i > 5)
                    break;

            } while (true);
        }


        static void EXM3()
        {
            int[] ids = new int[] { 16, 17, 18, 20 };

            // Use do-while loop to sum numbers in 4-element array.
            int sum = 0;
            int i = 0;
            do
            {
                sum += ids[i];
                i++;
            } while (i < 4);

            System.Console.WriteLine(sum);
        }

        //Nested do while loop
        static void EXM4()
        {
            int i = 0;
            do
            {
                Console.WriteLine("Value of i: {0}", i);
                int j = i;
                i++;
                do
                {
                    Console.WriteLine("Value of j: {0}", j);
                    j++;

                } while (j < 2);

            } while (i < 2);
        }

    }
}
