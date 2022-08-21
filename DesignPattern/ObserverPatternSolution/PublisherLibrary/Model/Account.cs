using System;
using System.Collections.Generic;

namespace PublisherLibrary.Model
{
    public class Account
    {
        private int _id;
        private string _name;
        private double _balance;
        private const double MINBALANCE = 500.0;
        private List<INotifier> _list = new List<INotifier>();

        public Account(int id, string name, double balance)
        {
            _id = id;
            _name = name;
            _balance = balance;
        }

        public void AddSubcriber(INotifier notifier)
        {
            _list.Add(notifier);
        }

        public void RemoveSubscriber(INotifier notifier)
        {
            if (_list.Contains(notifier))
            {
                _list.Remove(notifier);
            }
        }

        public void Deposit(double amount)
        {
            _balance += amount;
            AcknowledgeAllSubscriber();
        }

        private void AcknowledgeAllSubscriber()
        {
            foreach(INotifier notifier in _list)
            {
                notifier.Notify(this);
            }
        }

        public void Withdraw(double amount)
        {
            if (_balance - amount < MINBALANCE)
            {
                Console.WriteLine("Invalid");
            }
            else
            {
                _balance -= amount;
                AcknowledgeAllSubscriber();
            }
        }

        public int ID
        {
            get { return _id; }
        }

        public string Name
        {
            get { return _name; }
        }

        public double Balance
        {
            get { return _balance; }
        }
    }
    
}
