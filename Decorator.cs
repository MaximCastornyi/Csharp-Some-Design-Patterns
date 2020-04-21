interface IMessage
        {
            void PrintMessage();
        }

        abstract class Message : IMessage
        {
            protected string _text;
            public Message(string text)
            {
                _text = text;
            }
            abstract public void PrintMessage();
        }

        //The first class is a SimpleMessage
        class SimpleMessage : Message
        {
            public SimpleMessage(string text) : base(text) { }
            public override void PrintMessage()
            {
                Console.WriteLine(_text);
            }
        }

        //The second class is an AlertMessage
        class AlertMessage : Message
        {
            public AlertMessage(string text) : base(text) { }
            public override void PrintMessage()
            {
                Console.Beep();
                Console.WriteLine(_text);
            }
        }


