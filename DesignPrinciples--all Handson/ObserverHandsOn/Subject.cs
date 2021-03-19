using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverHandsOn
{
    public interface Subject

    {

        public void attach(Observer o);

        public void detach(Observer o);

        public void notifyUpdate(Message m);

    }

    public interface Observer

    {

        public void update(Message m);

    }


    public class Message

    {
        readonly string messageContent;
        public Message(String m) { this.messageContent = m; }
        public String GetMessageContent() { return messageContent; }
    }


    public class MessagePublisher : Subject
    {
        List<Observer> observers = new List<Observer>();
        public void attach(Observer o)
        {
            observers.Add(o);
        }

        public void detach(Observer o)
        {
            observers.Remove(o);
        }

        public void notifyUpdate(Message m)
        {
           foreach(var observer in observers)
            {
                observer.update(m);
            }
        }
    }

    public class MessageSubscriberOne : Observer
    {
        public void update(Message m)
        {
            Console.WriteLine($"Message subsciber one {m.GetMessageContent()}");
        }
    }

    public class MessageSubscriberTwo : Observer
    {
        public void update(Message m)
        {
            Console.WriteLine($"Message subsciber two {m.GetMessageContent()}");
        }
    }

    public class MessageSubscriberThree : Observer
    {
        public void update(Message m)
        {
            Console.WriteLine($"Message subsciber three {m.GetMessageContent()}");
        }
    }




}
