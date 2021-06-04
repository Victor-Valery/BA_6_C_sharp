using System;
using System.Threading;

namespace BA_C_SHARP_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // while loop

            int sayi = 10;

            while (sayi > 0)
            {
                Console.WriteLine("Hello World, su anda sayi degeri : " + sayi);
                sayi--;
            }

            // while döngüsü kullanarak bir sayac yapalim:

            Console.WriteLine("Kactan geri sayalim: ");
            int myNumber1 = int.Parse(Console.ReadLine());

            while (myNumber1 >= 0)
            {
                Console.WriteLine(myNumber1);
                Console.Beep();
                Thread.Sleep(500);
                myNumber1--;
            }

            Console.WriteLine("*****************");
            Console.WriteLine("Geri Sayim Tammalandi");
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();

            // 1'den baslayacak 
            // kullanicidan aldigimiz sayiya kadar gidecek.
            // while döngüsü kullanarak bir sayac yapalim.

            int start = 0;
            Console.WriteLine("Kaca kadar sayalim: ");
            int myNumber2 = int.Parse(Console.ReadLine());

            while (start <= myNumber2)
            {
                Console.WriteLine(start);
                Console.Beep();
                Thread.Sleep(500);
                start++;
            }

            Console.WriteLine("*****************");
            Console.WriteLine("Geri Sayim Tammalandi");
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();

        }
    }
}
