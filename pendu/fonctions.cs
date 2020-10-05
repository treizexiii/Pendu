using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace pendu
{
    partial class Program
    {
        static Random r = new Random();
        static string leMot()
        {
            string ligne,mot="";
            bool trouve = false;
           
            FileStream unFichierAuteur = new FileStream("mots.txt", FileMode.Open);
            StreamReader srAuteur = new StreamReader(unFichierAuteur);
            ligne = srAuteur.ReadLine();
            int i = 0;
            int alea = nombreAleatoire(1, 100);
            while (trouve == false)
            {
                if (ligne.Length == 6)
                {
                    i++;
                    if (i == alea)
                    {
                        trouve = true;
                        mot = ligne;

                    }
                
                
                   
                }

                ligne = srAuteur.ReadLine();
               
            }
            unFichierAuteur.Close();
            return mot;
        }
        static int nombreAleatoire(int min, int max)
        {

            int n = r.Next(min, max + 1);
            return n;
        }
        
        static void desEtoiles(int n)
        {
            for (int i = 1; i <= n; i++)
                Console.Write('*');
        }
        static bool estPresentLettre(string mot, char lettre)
        {
            bool trouve = false;
            for (int i = 0; i < mot.Length; i++)
            {
                if (mot[i] == lettre)
                {
                    trouve = true;

                }
            }
            return trouve;

        }
        static int[] rangsLettre(string mot, char lettre)
        {
            int j=0;
            List<int> rang= new List<int>();
           
            for (int i = 0; i < mot.Length; i++)
            {
                if (mot[i] == lettre)
                {
                    rang.Add(i);
                   
                }
            }

            return rang.ToArray();
        }
        static int nbElementsTableauEntiers(int[] t)
        {
            return t.Length;
        }
        static int longueur(string ch)
        {
            return ch.Length;
        }
        static string remplaceLettreDansMot(string s, char c, int rang)
        {

            char[] tab = s.ToCharArray();
            tab[rang] = c;
            string sr = "";
            for(int i=0;i<s.Length;i++)
            sr+=tab[i];
            return sr;
        }
      

    }
}
