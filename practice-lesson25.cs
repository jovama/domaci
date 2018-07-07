using System;

namespace Vezbanje
{
    class Program
    {

        //http://www.znanje.org/knjige/computer/cpp/n/081CPP/081cpp.htm naredna dva zadatka: 
        /*
        //Napisati program za ispis aritmeticke sredine neparnih prirodnih brojeva 1 do n.
        static void Main(string[] args)
        {
            int n, i = 1, counter = 0;
            int oddsum = 0; 
            double avg = 0.00;

            Console.WriteLine("Unesite broj n da bismo sracunali aritmeticku " +
                              "sredinu svih neparnih brojeva od 1 do n:");
            n = Convert.ToInt32(Console.ReadLine());

            while (i <= n)
            {
                oddsum = oddsum + i;
                counter++;
                i += 2;
            }

            avg = oddsum / counter;

            Console.WriteLine("Aritmeticka sredina brojeva od 1 do {0} iznosi {1}.", n, avg);
            Console.ReadKey();
        } 
        */
        /*
        //Prebrojati brojeve deljive sa 3 u intervalu od 1 do n.
        public bool Div3(int a)
        {
            if (a % 3 == 0)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            Program w = new Program();
            int n, i = 1, counter = 0;

            Console.WriteLine("Unesite broj n da bismo prebrojali koliko je " +
                              "brojeva od 1 do n deljivo sa 3:");
            n = Convert.ToInt32(Console.ReadLine());

            while (i <= n)
            {
                if (w.Div3(i))
                    counter++; 
                i++;
            }
            Console.WriteLine("Od 1 do {0} ima {1} broja/brojeva koji su deljivi sa 3.", n, counter);
            Console.ReadKey();
        }

        */
        //sled zadatak uzet iz liste na http://www.znanje.org/knjige/computer/cpp/n/080cpp/080_for_while_repeat_cpp.htm
        //Izračunati sumu prirodnih brojeva u intervalu od k do n koji su djeljivi sa a.

        static void Main(string[] args)
        {
            int k, n, a, i, sum = 0;

            Console.WriteLine("Unesite broj k - donju granicu niza prirodnih brojeva:");
            k = Convert.ToInt32(Console.ReadLine());
            i = k;
            Console.WriteLine("Unesite broj n - gornju granicu niza prirodnih brojeva:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Unesite broj a da bismo izracunali sumu prirodnih brojeva od k do n koji su deljivi sa a:");
            a = Convert.ToInt32(Console.ReadLine());

            while (i <= n)
            {
                if (i % a == 0)
                {
                    sum = sum + i;
                }
                i++;
            }
            Console.WriteLine("Suma prirodnih brojeva od {0} do {1} koji su deljivi sa {2} iznosi {3}.", k, n, a, sum);
            Console.ReadKey();
        }
    }
}
