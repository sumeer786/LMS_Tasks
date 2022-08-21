using System;
using PublisherLibrary.Model;

namespace SubscriberConsoleApp.Subscriber
{
    public class SMSNotification: INotifier
    {
        public SMSNotification()
        {

        }

        public void Notify(Account account)
        {
            Console.WriteLine("SMS has been sent to " + account.Name + " and the final balance is: " + account.Balance);
        }
    }
}
