using System;

namespace domaci22
{
    class Program
    {
        static void Main(string[] args)
        {
            //domaci - po dva primera za IF, ugnjezdeni IF, FOR i WHILE loop
            Console.WriteLine("Dobro dosli u domaci 22! Pritisnite bilo koji taster da nastavimo...");
            Console.ReadKey();

            //IF-ELSE koji proverava da li je korisnik punoletan

            Console.WriteLine("Krecemo sa if-else koja proverava da li je korisnik punoletan");
           
            int god;
            string ime;

            Console.WriteLine("Dobar dan! Koliko imate godina?");
            god = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A kako se zovete?");
            ime = Console.ReadLine();
            if ( god >= 18 )
            {
                Console.WriteLine("Punoletni ste! Welcome to the dark side, {0}, we have cookies! :)", ime);
            }
            else 
            {
                Console.WriteLine("Niste punoletni, {0}, al nemojte da zurite! Uzivajte tu gde jeste! :)", ime);
            }
            Console.ReadKey();


            //IF-ELSE koji proverava da li je godina prestupna
            /*
            Console.WriteLine("Niste sigurni da li je godina prestupna? Nema problema, provericemo!");
            Console.WriteLine("Unesite godinu da proverimo je li prestupna:");

            int y;
            y = Convert.ToInt32(Console.ReadLine());

            if ( y % 4 == 0 )
            {
                Console.WriteLine("{0}. jeste prestupna godina.", y);

            }
            else 
            {
                Console.WriteLine("Godina {0}. nije prestupna.", y);
            }
            Console.ReadKey();  
            */

            //ugnjezdeni IF koji proverava koji od tri broja je najveci
            /*
            Console.WriteLine("Sledeci zadatak je provera koji od tri uneta broja je najveci.");
            Console.WriteLine("Unesite tri broja:");

            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            if ( a > b )
            {
                if ( a > c ) 
                {
                    Console.WriteLine("Broj {0} je najveci.", a);    
                }
                else 
                {
                    Console.WriteLine("Broj {0} je najveci.", c);
                }

            }
            
            else if ( b > c)
            
            {
                Console.WriteLine("Broj {0} je najveci.", b);
            }
            
            else 

            {
                Console.WriteLine("Broj {0} je najveci.", c);
            }    
            
            Console.ReadKey();  
            */


            //ugnjezdeni IF koji proverava za dva uneta broja da li su jednaki i ako ne, koji broj je veci
            /*
            Console.WriteLine("U ovom zadatku proveravamo koji od dva uneta broja je veci.");
            Console.WriteLine("Unesite dva broja:");

            int br1, br2;
            br1 = Convert.ToInt32(Console.ReadLine());
            br2 = Convert.ToInt32(Console.ReadLine());

            if ( br1 != br2 )
            {
                if ( br1 > br2 ) 
                {
                    Console.WriteLine("Prvi broj ({0}) je veci od drugog ({1}).", br1, br2);    
                }
                else 
                {
                    Console.WriteLine("Drugi broj ({0}) je veci od prvog ({1}).", br2, br1);
                }

            }
            
            else
            
            {
                Console.WriteLine("Uneli ste dva jednaka broja.");
            }
            
            Console.ReadKey();  
            */

            //Sledi FOR petlja ciji je cilj da izracuna faktorijel zadatog broja.
            /*
            int n, fact;
            Console.WriteLine("Unesite broj n da bismo izracunali n! tj. n faktorijel:");

            n = Convert.ToInt32(Console.ReadLine());
            fact = 1;

            if (n != 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    fact = fact * i;
                }
            }
            else 
            { 
                fact = 1; 
            }

            Console.WriteLine("{0}! iznosi {1}.", n, fact);
            Console.ReadKey();
            */

            //Sledeca FOR petlja daje zbir cifara unetog broja.
            /*
            int broj, zbirc = 0, ost;
            Console.WriteLine("Unesite broj cije cifre zelite da saberemo:");

            broj = Convert.ToInt32(Console.ReadLine());

            for (int i = broj; i != 0; i = i / 10)
            {
                ost = i % 10;
                zbirc = zbirc + ost;
            }

            Console.WriteLine("Zbir cifara broja {0} iznosi {1}.", broj, zbirc);
            Console.ReadKey();

            //ubacila sam dodatnu proveru za deljivost sa 9 i shvatila da je super primena za ugnjezdeni IF
            Console.WriteLine("Zelite li da proverimo deljivost broja {0} sa 9? (da/ne)", broj);
            if (Console.ReadLine() == "da")
            {
                if (zbirc % 9 == 0)
                {
                    Console.WriteLine("Broj {0} jeste deljiv sa 9.", broj);
                }
                else
                {
                    Console.WriteLine("Broj {0} nije deljiv sa 9.", broj);
                }
            }
            else
            {
                Console.WriteLine("Ok, ne proveravamo deljivost.");
            }
            Console.ReadKey();
            */

            //Sledi WHILE loop koji za uneti broj m daje zbir brojeva od 1 do m
            /*
            int m, k = 1, suma = 0;
            Console.WriteLine("Unesite broj i dobicete zbir svih brojeva od 1 do unetog broja.");

            m = Convert.ToInt32(Console.ReadLine());

            while (k <= m)
            {
                suma = suma + k;
                k++;
            }

            Console.WriteLine("Suma svih brojeva od 1 do {0} iznosi {1}", m, suma);
            */

            //WHILE loop koji racuna faktorijel unetog broja u okviru WHILE loop-a
            //koji za svaki uneti broj racuna njegov faktorijel sve dok korisnik
            //ne odgovori sa "ne" na pitanje "zelite li da izracunate faktorijel jos jednog broja?"

            /*
            int j, factwh;
            string odgovor = "da";

            while (odgovor != "ne")
            {
                Console.WriteLine("Unesite broj da bismo izracunali njegov faktorijel:");

                j = Convert.ToInt32(Console.ReadLine());
                factwh = 1;

                if (j != 0)
                {
                    int brojac = 1;
                    while (brojac <= j)
                    {
                        factwh = factwh * brojac;
                        brojac++;
                    }
                }
                else
                {
                    factwh = 1;
                }

                Console.WriteLine("{0}! iznosi {1}.", j, factwh);
                Console.WriteLine("Zelite li da izracunate faktorijel jos jednog broja? (da/ne)");
                odgovor = Console.ReadLine();

            }
            Console.WriteLine("Kraj programa. Pozdrav!");
            Console.ReadKey();
            */
        }
    }
}
