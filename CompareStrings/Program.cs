﻿using System;

namespace CompareStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime ja perekonnanime
            //programm võrdleb sisestatud andmeid omavahel
            //programm kuvab konsoolis, kumb on pikem - eesnimi või perekonnanimi

            Console.WriteLine("Sisesta oma eesnimi:");
            string userFirstName = Console.ReadLine();

            Console.WriteLine("Sisesta oma perekonnanimi:");
            string userLastName = Console.ReadLine();

            if (userFirstName.Length > userLastName.Length)
            {
                Console.WriteLine("Sinu eesnimi on pikem kui perekonnanimi. ");
            }
            else if (userFirstName.Length < userLastName.Length)
            {
                Console.WriteLine("Sinu perekonnanimi on pikem, kui eesnimi. ");
            }
            else
            {
                Console.WriteLine("Sama pikad.");
            }

        }
    }
}
