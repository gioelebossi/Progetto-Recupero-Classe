using System;

namespace EsercizioRipasso
{
    class Program
    {
        struct piloti
        {
            public string nome;
            public string scuderia;
            public int punti;
        };

        const int NR = 20;
        const int NC = 10;

        static void Main(string[] args)
        {
            
            int[] circuiti=new int[NC];
            string[,] arrivi= new string[NR, NC];

            carica();

            int scelta;
            do
            {
                Console.WriteLine("Scegli l'operazione da effettuare");
                Console.WriteLine("1) Stampare l'elenco dei piloti appartenenti alla scuderia di cui viene fornito il nome");
                Console.WriteLine("2) Determinare il nome dei circuiti nei quali il pilota di cui viene fornito il nome ha vinto la gara ");
                Console.WriteLine("3) visualizzare la classifica di arrivo della gara per la quale è fornito in input il numero identificativo");
                Console.WriteLine("4) Calcolare i punti di ciascun pilota");
                Console.WriteLine("5) Esci dal programma");
                scelta = int.Parse(Console.ReadLine());
                Console.WriteLine("\n\n");
                switch (scelta)
                {
                    case 1:
                        
                        break;
                    case 2:
                        
                        break;
                    case 3:
                        
                        break;
                    case 4:
                        
                        break;
                    case 5:
                        Console.WriteLine("FINE");
                        break;
                    default:
                        Console.WriteLine("Scelta errata");
                        break;
                }
            } while (scelta != 5);

            Console.ReadKey();
        }
    }
}