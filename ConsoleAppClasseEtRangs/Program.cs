using System;

namespace ConsoleAppClasseEtRangs
{
    S
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Entrez le niveau du personnage : ");
            int niveau = int.Parse(Console.ReadLine());

            
            Console.WriteLine("Choisissez la classe principale de votre personnage :");
            Console.WriteLine("1 - Guerrier");
            Console.WriteLine("2 - Mage");
            Console.WriteLine("3 - Rogue");
            Console.Write("Entrez votre choix (1-3) : ");
            int classe = int.Parse(Console.ReadLine());

           
            Console.Write("Entrez le nombre de Quêtes Héroïques accomplies : ");
            int quetes = int.Parse(Console.ReadLine());


           
            string titreFinal = "";
            if (niveau >= 10 && quetes >= 5)
            {
                titreFinal = "Maître de Guilde";
            }
            else if (niveau >= 5 && quetes >= 3)
            {
                titreFinal = "Vétéran";
            }
            else if (niveau >= 3
              && quetes >= 1)
            {
                titreFinal = "Adepte";
            }
            else
            {
                titreFinal = "Novice";
            }

            Console.WriteLine($"Le titre final du héros est : {titreFinal}");

        }
    }
}

