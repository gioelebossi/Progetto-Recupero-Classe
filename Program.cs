using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EsercizioRipasso {
	class Program {
		struct Pilota {
			public string nome;
			public string scuderia;
			public int punti;
		};

		const int NR = 3;
		const int NC = 3;

		static void inserimentoDati(Pilota[] piloti, ref string[] nomiGare, int[, ] ordineArrivo) {
            // Un vettore passa per riferimento soltanto i suoi elementi, per questo, dopo aver inizializzato un nuovo vettore nel metodo di input
            // usiamo la parola chiave ref nel passaggio parametri per inizializzare per riferimento un nuovo vettore
            nomiGare = new string[] {
                "Monza",
				"Imola",
				"Fiorano",
				"Silverstone",
				"Spa",
				"Suzuka",
				"Monaco",
				"Baku",
				"Modena",
				"Austria"
            };

			string[] nomiScuderie = new string[] {
				"Alfa Romeo",
				"Alpha Tauri",
				"Mercedes",
				"Aston Martin",
				"Ferrari",
				"RedBull",
				"Mclaren",
				"Alpine",
				"Williams",
				"Haas"
			};

			for (int i = 0; i < NR; i++) {
				Console.WriteLine("inserisci il nome del pilota: ");
				piloti[i].nome = Console.ReadLine();

				for (int j = 0; j < nomiScuderie.Length; j++) {
					Console.WriteLine((j + 1) + ") " + nomiScuderie[j]);
				}

				Console.Write("inserire la scuderia: ");

				int numeroScuderia = int.Parse(Console.ReadLine());

				while (numeroScuderia < 0 || numeroScuderia >= nomiScuderie.Length) {
					Console.WriteLine("il numero delle scuderie non è valido, riprova!");
					numeroScuderia = int.Parse(Console.ReadLine());
				}

				piloti[i].scuderia = nomiScuderie[numeroScuderia - 1];
				piloti[i].punti = 0;
			}

			for (int j = 0; j < NC; j++) {
				Console.WriteLine("classifica gara: " + nomiGare[j]);

				for (int i = 0; i < NR; i++) {
					Console.WriteLine("pilota: " + piloti[i].nome);
					ordineArrivo[i, j] = int.Parse(Console.ReadLine());
				}
			}
            return;
		}

        static bool pilotaInScuderia(string scud, Pilota[] piloti)
        {
            for (int i = 0; i < piloti.Length; i++)
            {
                if (scud == piloti[i].scuderia)
                {
                    return true;
                }
            }

            return false;
        }

		static void stampa(Pilota[] piloti) {
			string scud;
			Console.WriteLine("Inserire la scuderia di cui si vogliono visualizzare i piloti");
			scud = Console.ReadLine();

            if (!pilotaInScuderia(scud, piloti))
            {
                Console.WriteLine("Non ci sono piloti nella scuderia selezionata");
                return;
            }

			Console.WriteLine("I piloti della scuderia " + scud + " sono");

			for (int i = 0; i < piloti.Length; i++) {
				if (scud == piloti[i].scuderia) {
					Console.WriteLine(piloti[i].nome);
				}
			}

		}

		static void vittoriePilota(Pilota[] piloti, int[, ] arrivi, string[] circuiti) {
			string n;
			int row = 0;

			Console.WriteLine("Inserire un pilota: ");
			n = Console.ReadLine();

			for (int i = 0; i < NR; i++) {
				if (n == piloti[row].nome) {
					break;
				}
				row++;
			}

			if (row == NR) {
				Console.WriteLine("Non esiste il pilota.");
			} else {
				Console.WriteLine("Il pilota ha vinto le gare: ");
				for (int i = 0; i < NR; i++) {
                    int counter = 0;
					if (arrivi[i, row] == 1) {
						Console.Write(circuiti[i] + " ");
                        counter++;
					}

                    if (counter == 0)
                        Console.WriteLine("Il pilota non ha vinto nessuna gara");
				}
			}
            Console.WriteLine("\n");
		}

		static void visualizzaClassifica(Pilota[] piloti, string[] nomiGare, int[, ] ordineArrivo) {
			int nid;
			do {
				Console.WriteLine("Inserire il numero identificativo della gara(1-10)");
				nid = int.Parse(Console.ReadLine());
			} while (nid > 10 || nid < 1);


            String[] pilotiOrdinati = new String[piloti.Length];

            for (int i = 0; i < piloti.Length; i++)
            {
                pilotiOrdinati[ordineArrivo[nid - 1, i] - 1] = piloti[i].nome;
            }

			for (int i = 1; i <= pilotiOrdinati.Length; i++) {
				Console.WriteLine(i +". " + pilotiOrdinati[i - 1]);
			}

		}

		static void calcolaPunti(Pilota[] piloti, string[] nomiGare, int[, ] ordineArrivo) {
			for (int i = 0; i < NR; i++) {
				for (int j = 0; j < NC; j++) {
					switch (ordineArrivo[i, j]) {
						case 1:
							piloti[i].punti += 25;
							break;
						case 2:
							piloti[i].punti += 20;
							break;
						case 3:
							piloti[i].punti += 15;
							break;
						default:
							if (ordineArrivo[i, j] <= 10) {
								piloti[i].punti += 11 - ordineArrivo[i, j];
							}
							break;
					}
				}
			}

            for(int i = 0; i < piloti.Length - 1; i++) {
                for(int j = i; j < piloti.Length - 1; j++) {
                    if (piloti[j].punti < piloti[j + 1].punti)
                    {
                        Pilota temp = piloti[j];
                        piloti[j] = piloti[j + 1];
                        piloti[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\nPosizione\tNome\tPunti\n");
            for (int i = 1; i <= piloti.Length; i++)
            {
                Console.WriteLine(i + ". \t\t" + piloti[i - 1].nome + "\t" + piloti[i - 1].punti);
            }

            Console.WriteLine("\n\n");
		}



        static void Main(string[] args)
        {

			string[] circuiti = new string[NC];
			int[, ] arrivi = new int[NR, NC];
			Pilota[] piloti = new Pilota[NR];

			inserimentoDati(piloti, ref circuiti, arrivi);

			int scelta;
			do {
				Console.WriteLine("Scegli l'operazione da effettuare");
				Console.WriteLine("1) Stampare l'elenco dei piloti appartenenti alla scuderia di cui viene fornito il nome");
				Console.WriteLine("2) Determinare il nome dei circuiti nei quali il pilota di cui viene fornito il nome ha vinto la gara");
				Console.WriteLine("3) Visualizzare la classifica di arrivo della gara per la quale è fornito in input il numero identificativo");
				Console.WriteLine("4) Calcolare i punti di ciascun pilota");
				Console.WriteLine("5) Esci dal programma");
				scelta = int.Parse(Console.ReadLine());
				Console.WriteLine("\n\n");
				switch (scelta) {
					case 1:
						stampa(piloti);
						break;
					case 2:
                        vittoriePilota(piloti, arrivi, circuiti);
						break;
					case 3:
						visualizzaClassifica(piloti, circuiti, arrivi);
						break;
					case 4:
						calcolaPunti(piloti, circuiti, arrivi);
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
