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

            Console.WriteLine("qual'é il titolo del vostro programma di eventi?");
            string titolopro = Console.ReadLine();

            ProgrammaEventi pro1 = new ProgrammaEventi(titolopro);
            Console.WriteLine("quanti eventi vuoi aggiungere?");
            int qtaEventi = Convert.ToInt32(Console.ReadLine());
            

        }
    }
}