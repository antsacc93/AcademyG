using AcademyG.Week1.DelegateAndEventi.Pub_Sub;
using System;

namespace AcademyG.Week1.DelegateAndEventi
{
    public class Funzionalita
    {
        public static void EsempioSugliEventi()
        {
            //Creazione di publishers
            Publisher youtube = new Publisher("YouTube.com");
            Publisher instagram = new Publisher("Instagram");

            //Creazione di subscribers
            Subscriber sub1 = new Subscriber("Mario");
            Subscriber sub2 = new Subscriber("Renata");
            Subscriber sub3 = new Subscriber("Mirko");

            sub1.Subscribe(youtube);
            sub2.Subscribe(youtube);
            sub3.Subscribe(youtube);

            sub1.Subscribe(instagram);
            sub3.Subscribe(instagram);

            youtube.Publish();
            Console.WriteLine("-------");
            instagram.Publish();

            Console.WriteLine("-------");
            sub3.Unsubscribe(youtube);

            youtube.Publish();
        }
    }
}