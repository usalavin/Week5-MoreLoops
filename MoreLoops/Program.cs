﻿using System;

namespace MoreLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus ja salasõna
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna on "admin1234" 
            // siis konsoolis kuvatakse "tere tulemst"
            //muul juhul konsoolis kuvatakse "Vale kasutajatunnus või salasõna. Proovi uuesti"


            Console.WriteLine("Sisesta kasutajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta salasõna");
            string userPassword = Console.ReadLine();

            //AND (&&)

            //"admin" AND "admin1234" --- true
            //"admin1" AND "admin12345" --- false
            //"admin" AND "admin12345" --- false
            //"admin145" AND "admin1234567" --- false


            if(userName == "admin" && userPassword == "admin1234")
            {
                Console.WriteLine("Tere tulemast!");
            }

            else
            {
                Console.WriteLine("Vale kasutajatunnus või salasõna. Proovi uuesti.");
            }


        }
    }
}
