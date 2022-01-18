using System;

namespace EsercizioRipasso {
	class Program {
		struct Pilota {
			public string nome;
			public string scuderia;
			public int punti;
		};

		const int NR = 20;
		const int NC = 10;

		static void stampa(Pilota[] piloti) {
			string scud;
			Console.WriteLine("Inserire la scuderia di cui si vogliono visualizzare i piloti");
			scud = Console.ReadLine();

			Console.WriteLine("I piloti della scuderia " + scud + " sono");

			for (int i = 0; i < piloti.Length; i++) {
				if (scud == piloti[i].scuderia) {
					Console.WriteLine(piloti[i].nome);
				}
			}

		}

		static void vittoriePilota(Pilota[] piloti, int[, ] arrivi, string[] circuiti) {
			string n;
			int a = 0;

			Console.WriteLine("Inserire un pilota: ");
			n = Console.ReadLine();

			for (int i = 0; i < NR; i++) {
				if (n == piloti[a].nome) {
					break;
				}
				a++;
			}

			if (a == NR) {
				Console.WriteLine("Non esiste il pilota.");
			}
			else {
				Console.WriteLine("Il pilota ha vinto le gare: ");
				for (int i = 0; i < NR; i++) {
					if (arrivi[a, NR] == 1) {
						Console.Write(circuiti[i] + " ");
					}
				}
			}
		}

		static void Main(string[] args) {

			string[] circuiti = new string[NC];
			int[,] arrivi = new int[NR, NC];
			Pilota[] piloti = new Pilota[NR];

			carica();

			int scelta;
			do {
				Console.WriteLine("Scegli l'operazione da effettuare");
				Console.WriteLine("1) Stampare l'elenco dei piloti appartenenti alla scuderia di cui viene fornito il nome");
				Console.WriteLine("2) Determinare il nome dei circuiti nei quali il pilota di cui viene fornito il nome ha vinto la gara ");
				Console.WriteLine("3) visualizzare la classifica di arrivo della gara per la quale è fornito in input il numero identificativo");
				Console.WriteLine("4) Calcolare i punti di ciascun pilota");
				Console.WriteLine("5) Esci dal programma");
				scelta = int.Parse(Console.ReadLine());
				Console.WriteLine("\n\n");
				switch (scelta) {
				case 1:

					break;
				case 2:

					break;
				case 3:
					stampa(piloti);
					break;
				case 4:
					vittoriePilota(piloti, arrivi, circuiti);
					break;
				case 5:
					Console.WriteLine("FINE");
					break;
				default:
					Console.WriteLine("Scelta errata");
					break;
				}
			} while ( scelta != 5 );

			Console.ReadKey();
		}

	}
}
