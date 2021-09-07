using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyG.Week1.DelegateAndEventi.Pub_Sub
{
    public class Subscriber
    {
        //Proprietà
        public string SubscriberName { get; set; }
        //Costruttore
        public Subscriber(string name)
        {
            SubscriberName = name;
        }

        //Metodi di Subscribe/Unsubscribe
        public void Subscribe(Publisher p)
        {
            //registrazione all'evento di notifica
            p.OnPublish += OnNotificationReceived;
        }

        public void Unsubscribe(Publisher p)
        {
            //cancellazione dalla lista dei sottoscrittori
            p.OnPublish -= OnNotificationReceived;
        }

        public void OnNotificationReceived(Publisher p, Notification n)
        {
            Console.WriteLine($"Ciao {SubscriberName}, è stato pubblicato un evento da {p.PublisherName} \n" +
                $"{n.NotificationDate.ToShortDateString()} - {n.NotificationMessage}");
        }
    }
}
