using System;
using System.Collections.Generic;
using System.Text;

namespace VSNewFeatureDemo.Examples.CodeMap
{
    class DebugCallStackExample : IExample
    {
        private static MyMessage FMessage = new MyMessage();

        public void Show()
        {
            FMessage.SendMessage("Message " + DateTime.Now);

            FMessage.Clear();
        }
    }

    class MyMessage
    {
        private List<string> FMessages = new List<string>();
        private string FLastMessage = null;

        public string LastMessage { get { return FLastMessage; } }

        public void SendMessage(string aMessage)
        {
            Console.WriteLine("Last Message: " + LastMessage);
            FLastMessage = aMessage;
            FMessages.Add(FLastMessage);
            Console.WriteLine("New Message: " + LastMessage);
        }

        public void Clear()
        {
            FMessages.Clear();
        }
    }
}
