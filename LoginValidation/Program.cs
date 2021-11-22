using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus ja salasõna
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna on "admin1234" 
            // siis konsoolis kuvatakse "tere tulemst"
            //muul juhul konsoolis kuvatakse "Vale kasutajatunnus või salasõna. Proovi uuesti"
            //kasutajal on kolm katset



            int i = 0;
            while (i < 3)
            {
                Console.WriteLine("Sisesta kasutajatunnus:");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisesta salasõna");
                string userPassword = Console.ReadLine();

                if (userName != "admin" || userPassword != "admin1234")
                {
                    i = i + 1;
                    Console.WriteLine($"Vale kasutajatunnus või salasõna. {3 - i} katsest on jäänud.");
                    
                }
             
                else
                {

                    Console.WriteLine("Tere tulemast!");
                    break;
                }

            }
            Console.WriteLine("Kena päeva!");




        }










    }
    }

