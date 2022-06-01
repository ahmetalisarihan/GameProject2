using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new Concretes.UserValidationManager());
            gamerManager.Add(new Gamer
            { 
            Id =1,
            BirthYear = 1994,
            FirstName = "AHMET ALİ",
            LastName ="SARIHAN",
            IdentityNumber = 57607308534
            

            });

;        }
    }
}
