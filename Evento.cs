using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    internal class Evento
    {
        public string? Titolo { get; set; }
        public DateTime? Data { get; set; }
        public int CapienzaPosti { get;}

        public int PostiPrenotati;
        public Evento(string titolo, DateTime data, int capienzaPosti)
        {
            if(string.IsNullOrEmpty(titolo))
                throw new ArgumentException("Il titolo dell'evento non può essere vuoto");

            if (data < DateTime.Now)
                throw new ArgumentException("la data dell'evento deve essere futura!");

            if (capienzaPosti <= 0)
                throw new ArgumentException("La capienza deve essere superiore a 0 posti!");



            Titolo = titolo;
            Data =  data;
            CapienzaPosti = capienzaPosti;
            this.PostiPrenotati = 0;
        }

        public int postiPrenotati
        {
            get { return PostiPrenotati; }
        }

        //1.	PrenotaPosti: aggiunge i posti passati come parametro ai posti prenotati.
        //Se l’evento è già passato o non ha posti o non ha più posti disponibili deve sollevare un’eccezione.
        public void PrenotaPosti (int prenotaposti)
        {
            if (Data < DateTime.Now)
                throw new ArgumentException("Non puoi prenotare dei posti per un evento Passato!");

            if (CapienzaPosti <= 0)
                throw new InvalidOperationException("Non ci sono posti disponibili!");

            if (PostiPrenotati >= CapienzaPosti)
                throw new ArgumentException("Tutti i posti sono stati prenotati!");

            PostiPrenotati += prenotaposti;

            
        }

        //DisdiciPosti: riduce i posti prenotati del numero di posti indicati come parametro.
        //Se l’evento è già passato o non ci sono i posti da disdire sufficienti, deve sollevare un’eccezione.
        public void DisdiciPosti (int disdiciPosti)
        {
            if (Data < DateTime.Now)
                throw new ArgumentException("Non puoi disdire dei posti per un evento Passato!");

            if (disdiciPosti > PostiPrenotati)
                throw new ArgumentException("Non puoi disdire più posti di quanti, ne sono stati prenotati!");

            PostiPrenotati -= disdiciPosti;
        }
        public int PostiDisponibili()
        {
            return  CapienzaPosti - PostiPrenotati;
        }

    }
}
