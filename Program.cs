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

            while (sayi>0)
            {
                Console.WriteLine("Hello World, su anda sayi degeri : "+ sayi);
                sayi--;
            }


            // while döngüsü kullanarak bir sayac yapalim:

            Console.WriteLine("Kactan geri sayalim: ");
            int myNumber = int.Parse(Console.ReadLine());


            while (myNumber>=0)
            {
                Console.WriteLine(myNumber);
                Thread.Sleep(1000);
                myNumber--;
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
