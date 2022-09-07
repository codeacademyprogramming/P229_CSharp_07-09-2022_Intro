using System;

namespace P229FirstCSharpProject
{

    class Program
    {

        static void Main(string[] args)
        {
            #region Test Region
            //var name = "Hamid";

            //var age = 15;

            //age = 54654;
            #endregion

            #region Variable data Type
            //Console.WriteLine(age);

            //age = 5646;

            //Console.WriteLine(age);

            //dynamic test = 15;

            //Console.WriteLine(test);


            //test = "Hamid";

            //Console.WriteLine(test);

            //byte age = 32;
            //sbyte temp = 127;
            //short a = 30000;
            //ushort b = 60000;

            //Console.WriteLine(age);

            //float test = -3.14F;

            //Console.WriteLine(test);

            //double price = 13;

            //decimal price2 = 13.99m;

            //char symbol = '/';

            //bool check = true;

            //string name = "Hamid jkshkjashkahdkahskdjh";
            #endregion

            #region Operator
            //int a = 15;
            //int b = 5;

            //int result = a / b;
            #endregion

            #region Condition
            //if (a == 5)
            //{
            //    Console.WriteLine("a b-den Boyukdur");
            //}
            //else if (a == b)
            //{
            //    Console.WriteLine("a b-e Beraberdir");
            //}
            //else if(a == 15)
            //{
            //    Console.WriteLine("b a-dan Boyukdur");
            //}
            //else
            //{
            //    Console.WriteLine("Hecne");
            //}

            //switch (a)
            //{
            //    case 5:
            //        Console.WriteLine(a *= 7);
            //        break;
            //    case 10:
            //        Console.WriteLine(a *= 7);
            //        break;
            //    case 15:
            //        Console.WriteLine(a *= 7);
            //        break;
            //    default:
            //        break;
            //}
            #endregion

            #region Loops
            //int min = 0;
            //int max = 50;

            //while(min <= max)
            //{
            //    Console.WriteLine(min);

            //    min++;

            //    int a = 50;
            //}


            //do
            //{
            //    Console.WriteLine(min);

            //    min++;

            //    int a = 50;
            //} while (min < max);

            //Console.WriteLine(min);;

            //for(int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine(i);

            //    for (int j = 0; j < 50; j++)
            //    {

            //    }
            //}


            #endregion

            #region Task 1
            //int a = 5, b = 15, sum = 0;

            //while (a <= b)
            //{
            //    sum += a;
            //    a++;
            //}

            //Console.WriteLine(sum);
            #endregion

            #region Task 2
            //1-den 100 -e tek ededlerin sayi

            //int count = 0;

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine(count);
            #endregion

            #region Task 3
            //Daxil Edilmis Ededin Reqemlerni Ayri Ayri Consola Yazdirma

            int num = 654654;

            while (num > 0)
            {
                int module = num % 10;
                num = (num - module) / 10;
                Console.WriteLine(module);
            }
            #endregion
        }
    }
}
