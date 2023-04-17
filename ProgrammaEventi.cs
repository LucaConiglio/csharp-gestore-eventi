using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    internal class ProgrammaEventi
    {
        public string Titolo { get; set; }
        public List<Evento> Eventi;

        public ProgrammaEventi(string titolo)
        {
            if (string.IsNullOrEmpty(titolo))
                throw new ArgumentException("Il titolo dell'evento non può essere vuoto");

            Titolo = titolo;
            Eventi = new List<Evento>();
        }

        //un metodo che aggiunge alla lista del programma eventi un Evento, passato come parametro al metodo.
        public void AggiungiEvento(Evento evento)
        {
            Eventi.Add(evento);
        }

        //un metodo che restituisce una lista di eventi con tutti gli eventi presenti in una certa data.
        public List<Evento> EventiInData(DateTime data)
        {
            return Eventi.FindAll(e =>  e.Data == data.Date);
        }

        //un metodo statico che si occupa, presa una lista di eventi, di stamparla in Console,
        //o ancora meglio vi restituisca la rappresentazione in stringa della vostra lista di eventi.
        public static void StampaListaEventi(List<Evento> Eventi)
        {
            
            foreach (Evento evento in Eventi) 
            {
                Console.WriteLine("Evento: " + evento.Titolo + " data: " +  evento.Data);
            }
        }
        public int NumeroEventi()
        {
            return Eventi.Count();
        }
        public void SvuotaEventi()
        {
            Eventi.Clear();
        }

        
    }
}
