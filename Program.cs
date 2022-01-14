using System;

namespace EsercizioRipasso
{
    class Program
    {
        static void stampa(Pilota[] piloti) //gruppo 4
        {
            string scud;
            Console.WriteLine("inserire la scuderia di cui si vogliono visualizzare i piloti");
            scud = Console.ReadLine();
            Console.WriteLine("i piloti della scuderia " + scud + " sono");
            for (int i = 0; i < piloti.Length; i++)
            {
                if (scud == scuderia[i])
                {
                    Console.WriteLine(nome[i]);
                }
            }

        }

        void vittoriePilota(Pilota[] piloti, int[,] ordineArrivo, string[] nomiGare) //gruppo 4
        {
            string n;
            int a = 0;

            {
            Console.WriteLine("Inserire un pilota: ");
            n = Console.ReadLine();

           for (int i = 0; i < NR; i++)
            }
                if (n == Pilota[a].piloti)
                {
                    break;
                }
                a++;
            } 
            
            if (a == NR)
            {
                Console.WriteLine("Non esiste il pilota.");   
            }
            else
            {
                Console.WriteLine("Il pilota ha vinto le gare: ");
                for (int i = 0; i < NR; i++)
                {
                    if (ordineArrivo[a, NR] == 1)
                    {
                    Console.Write(nomiGare[i]+" ");
                    }
                }
            }

            
        }

        static void Main(string[] args)
        {
            // Codice del main
        }
    }
}
