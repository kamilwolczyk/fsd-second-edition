using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fsd.Maciej.Cs.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            INotificationAction writer = new EventLogWriter();
            INotificationAction email = new EmailSender();
            INotificationAction sms = new SMSSender();
            IISAppPoolWatcher watcher =new IISAppPoolWatcher();

            watcher.Action = writer;
            watcher.Notify("IIS przestał odpowiadać.");

            watcher.Action=email;
            watcher.Notify("IIS przestał odpowiadać.");


            watcher.Action=sms;
            watcher.Notify("IIS przestał odpowiadać.");
            Console.ReadKey();
        }
        class EventLogWriter : INotificationAction
        {
            public void ActOnNotification(string message)
            {
                // zapisywanie logów do pliku dziennika
                Console.WriteLine("Dziennik zdarzeń: {0}", message);
            }
        }
        class EmailSender : INotificationAction
        {
            public void ActOnNotification(string message)
            {
                // wysyłanie wiadomość email do administratora
                Console.WriteLine("Wysyłam EMAIL: {0}", message);
            }
        }
        class SMSSender : INotificationAction
        {
            public void ActOnNotification(string message)
            {
                // wysyłanie wiadomości sms do administratora
                Console.WriteLine("Wysyłam SMS: {0}", message);
            }
        }
        class IISAppPoolWatcher
        {
            
            // Handler naszego interfejsu do którego zostanie przypisana konkretna implementacja
            INotificationAction action = null;

            public INotificationAction Action { get; set; }
            
            public void Notify(string message)
            {
                action = Action;
                action.ActOnNotification(message);
            }
        }
        public interface INotificationAction
        {
            void ActOnNotification(string message);
        }
    }
}
