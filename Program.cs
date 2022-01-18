using System;

namespace EsercizioRipasso
{
    class Program
    {
        static void Main(string[] args)
        {
            // Codice del main
        }

        static void inserimentoDati(Pilota[] piloti, string[] nomiGare, int[,] ordineArrivo)
        {
            nomiGare = new String[] {"Monza", "Imola", "Fiorano", "Silverstone", "Spa", "Suzuka", "Monaco", "Baku", "Modena", "Austria"};
            string[] nomiScuderie = new String[] {"Alfa Romeo","Alpha tauri","Mercedes","Asron Martin","Ferrari","RedBull","Mclaren","Alpine","Williams","Haas"};
            for (int i = 0; i < NP; i++)
            {
                Console.WriteLine("inserisci il nome del pilota: ");
                piloti[i].nome = Console.ReadLine();
                for (int j = 0; j < nomiScuderie.Length; j++)
                {
                    Console.WriteLine((j+1)+") "+nomiScuderie[j]);
                }
                Console.Write("inserire la scuderia: ");
            
                int numeroScuderia =int.Parse(Console.ReadLine());
                while(numeroScuderia > 0 || numeroScuderia <= nomiScuderie.Length)
                {
                    Console.WriteLine("il numero delle scuderie non è valido, riprova!");
                    numeroScuderia =int.Parse(Console.ReadLine());
                }

                piloti[i].scuderia = nomiScuderie[numeroScuderia -1];
                piloti[i].punti = 0;
            }
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("classifica gara: "+nomigare[j])
                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine("pilota: "+piloti[i].nome);
                    OrdineArrivo[i,j] =int.Parse(Console.ReadLine());
                }
            }
        }

    }
}
