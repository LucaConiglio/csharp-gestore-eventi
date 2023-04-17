using System.Runtime.InteropServices;

namespace csharp_gestore_eventi
{
    internal class Program
    {
        //public static void RicicloAffermazione()
        //{
        //    Console.WriteLine("desidera disdire dei posti? (si/no)");
        //    string affermazioneUtente = Console.ReadLine();
        //    bool affermazione = affermazioneUtente == "si";
        //}

        public static void Riciclo(Evento e1)
        {
            Console.WriteLine("Vuoi effettuare delle prenotazioni? (si/no)");
            string prenotazioni = Console.ReadLine();

            if(prenotazioni == "si")
            {
                Console.WriteLine("quanti posti vuoi prenotare?");
                int postidaprenotare = int.Parse(Console.ReadLine());
                e1.PrenotaPosti(postidaprenotare);
                Console.WriteLine($"numero posti prenotati: {e1.PostiPrenotati}, posti ancora disponibili: {e1.PostiDisponibili()}");
                //ora chiedere all’utente fintanto che lo desidera, se e quanti posti vuole disdire.
                //ogni volta che disdice dei posti, stampare i posti residui e quelli prenotati.

                Console.WriteLine("desidera disdire dei posti? (si/no)");
                string affermazioneutente = Console.ReadLine();
                bool affermazione = affermazioneutente == "si";

                while (affermazione == true)
                {
                    Console.WriteLine("quanti posti vuole disdire?");
                    int postidadisdire = int.Parse(Console.ReadLine());
                    e1.DisdiciPosti(postidadisdire);
                    Console.WriteLine($"numero posti prenotati: {e1.PostiPrenotati}, posti ancora disponibili: {e1.PostiDisponibili()}");
                    Console.WriteLine("desidera disdire dei posti? (si/no)");
                    affermazioneutente = Console.ReadLine();
                    affermazione = affermazioneutente == "si";
                    if (affermazioneutente == "no")
                        Console.WriteLine("ok, va bene!");
                }
            }
            else
                Console.WriteLine("ok, va bene!");
        }

        //**************************************************************************************//
        static void Main(string[] args)
        {

            //Console.WriteLine("Inserisci il Titolo dell'evento da creare");
            //string titolo = Console.ReadLine();

            //Console.WriteLine("Inserisci la data dell'evento in questo formato (gg/mm/YYYY):"); 

            //DateTime data = new DateTime();
            //string input = Console.ReadLine();
            //data = DateTime.Parse(input);

            //Console.WriteLine("Inserisci il numero dei posti massimi dell'evento da creare!");
            //int numeroPosti = Convert.ToInt32(Console.ReadLine());

            //Evento e1 = new Evento(titolo, data, numeroPosti);

            //Console.WriteLine("Vuoi effettuare delle prenotazioni? (si/no)");
            //string prenotazioni = Console.ReadLine();

            //if(prenotazioni == "si")
            //{
            //    Console.WriteLine("Quanti posti vuoi prenotare?");
            //    int postidaPrenotare = Convert.ToInt32(Console.ReadLine());
            //    e1.PrenotaPosti(postidaPrenotare);
            //    Console.WriteLine($"Numero posti prenotati: {e1.PostiPrenotati}, posti ancora disponibili: {e1.PostiDisponibili()}");
            //    //Ora chiedere all’utente fintanto che lo desidera, se e quanti posti vuole disdire.
            //    //Ogni volta che disdice dei posti, stampare i posti residui e quelli prenotati.

            //    Console.WriteLine("desidera disdire dei posti? (si/no)");
            //    string affermazioneUtente = Console.ReadLine();
            //    bool affermazione = affermazioneUtente == "si";

            //    while (affermazione == true)
            //    {
            //        Console.WriteLine("quanti posti vuole disdire?");
            //        int postidaDisdire = Convert.ToInt32(Console.ReadLine());
            //        e1.DisdiciPosti(postidaDisdire);
            //        Console.WriteLine($"Numero posti prenotati: {e1.PostiPrenotati}, posti ancora disponibili: {e1.PostiDisponibili()}");
            //        Console.WriteLine("desidera disdire dei posti? (si/no)");
            //        affermazioneUtente = Console.ReadLine();
            //        affermazione = affermazioneUtente == "si";
            //        if (affermazioneUtente == "no")
            //            Console.WriteLine("Ok, va bene!");
            //    }
            //}
            //else
            //    Console.WriteLine("Ok, va bene!");

            Console.Write("Inserisci il titolo del programma di eventi? ");
            string titolopro = Console.ReadLine();
            Console.WriteLine();
            ProgrammaEventi pro1 = new ProgrammaEventi(titolopro);
            Console.Write("quanti eventi vuoi aggiungere? ");
            int qtaEventi = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for(int i = 0; i < qtaEventi; i++)
            {
                Console.WriteLine($"inserimento del {i+1}° Evento");
                Console.Write("Titolo: ");
                string titolo = Console.ReadLine();

                Console.Write("Data (formato gg/mm/aaaa): ");
                DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

                Console.Write("Quantità posti: ");
                int posti  = int.Parse(Console.ReadLine());

                Evento evento = new Evento(titolo, data, posti);

                Riciclo(evento);

                pro1.AggiungiEvento(evento);
                Console.WriteLine();
            }

            Console.WriteLine("Il numero di eventi nel programma é di: " + pro1.NumeroEventi());
            Console.WriteLine();

            Console.WriteLine("Ecco il tuo programma Eventi: ");
            ProgrammaEventi.StampaListaEventi(pro1.Eventi);



        }
    }
}