using System;

namespace AcademyG.Week1.DelegateAndEventi.Pub_Sub
{
    public class Notification
    {
        //PROPRIETA'
        public string NotificationMessage { get; set; }
        public DateTime NotificationDate { get; set; }

        //COSTRUTTORE
        public Notification(DateTime date, string message)
        {
            NotificationDate = date;
            NotificationMessage = message;
        }

    }
}