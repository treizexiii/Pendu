using System;

namespace pendu
{
    partial class Program
    {
        static void Main(string[] args)
        {
            string mot = "******";
            int numeroEssai = 1;
            int j = 0;
            bool trouve = false;
            string motCherche = leMot();
            Console.WriteLine(motCherche);      // pour tester
            int[] t;
            while (trouve == false && numeroEssai <= 10)
            {
                Console.WriteLine("Choisissez une lettre");
                char lettre = Convert.ToChar(Console.ReadLine());


                if (estPresentLettre(motCherche, lettre))
                {
                    t = rangsLettre(motCherche, lettre);
                    j = nbElementsTableauEntiers(t);
                    for (int i = 0; i < j; i++)
                    {
                        mot = remplaceLettreDansMot(mot, lettre, t[i]);
                    }
                }
                Console.WriteLine(mot);
                numeroEssai += 1;
                if (mot == motCherche)
                {
                    trouve = true;
                }
            }
            if (trouve == true)
            {
                Console.WriteLine("Bravo");
            }
            else
            {
                Console.WriteLine("Perdu");
            }
            Console.ReadKey();

        }
    }
}
