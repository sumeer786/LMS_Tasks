using System;
using PublisherLibrary.Model;

namespace SubscriberConsoleApp.Subscriber
{
    public class EmailNotification : INotifier
    {
        public EmailNotification()
        {

        }

        public void Notify(Account account)
        {
            Console.WriteLine("E-Mail has been sent to " + account.Name + " and the final balance is: " + account.Balance);
        }
    }
}
