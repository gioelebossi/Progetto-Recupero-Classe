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

        void vittoriePilota(Pilota[] piloti, int[,] ordineArrivo) //gruppo 4
        {
            bool z = false;
            string n;
            int X = ordineArrivo[1], a = 0;

            Console.WriteLine("Inserire un pilota: ");
            n = Console.ReadLine();

            do
            {
                if (n == Pilota[a].piloti)
                {
                    z = true;
                    a--;
                }
                a++;
            } while (z == false);

            Console.WriteLine("Il pilota ha vinto le gare: ");
            for (int i = 0; i < X; i++)
            {
                if (ordineArrivo[a, X] == 1)
                {
                    Console.WriteLine(ordineArrivo[a, X]);
                }

            }
        }

        static void Main(string[] args)
        {
            // Codice del main
        }
    }
}
