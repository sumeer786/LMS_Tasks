using System;
using PublisherLibrary.Model;
using SubscriberConsoleApp.Subscriber;

namespace SubscriberConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(101,"sumeer",1000);
            account.AddSubcriber(new SMSNotification());
            account.AddSubcriber(new EmailNotification());
            account.Deposit(1000);

        }
    }
}
