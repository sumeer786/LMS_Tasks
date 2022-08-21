using System;
namespace PublisherLibrary.Model
{
    public interface INotifier
    {
        void Notify(Account account);
    }
}
