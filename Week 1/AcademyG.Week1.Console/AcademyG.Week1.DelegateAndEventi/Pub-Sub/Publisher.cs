using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.Week1.DelegateAndEventi.Pub_Sub
{
    public class Publisher
    {
        //Proprietà
        public string PublisherName { get; set; }

        //Costruttore
        public Publisher() { } //costruttore no-arg sempre presente di default

        public Publisher(string publisherName)
        {
            PublisherName = publisherName;
        }

        //Delegate che punta a funzioni di notifica
        public delegate void Notify(Publisher pub, Notification notification);

        public event Notify OnPublish; //L'evento dichiarato dal publisher è di tipo notify
                                       // ovvero un puntatore a funzione che prende in input colui
                                       // che pubblica l'evento e la notifica da trasmettere
        
        //metodo che pubblica l'evento
        public void Publish()
        {
            if(OnPublish != null)
            {
                Notification notifica = new Notification(DateTime.Now, "Nuova notifica per te");
                OnPublish(this, notifica);
            }
        }
    }
}
