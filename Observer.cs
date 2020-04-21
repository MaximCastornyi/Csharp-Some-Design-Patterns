//The Subject class contains a private quantity field that is updated by a public UpdateQuantity method

class Subject
        {
            private int _quantity = 0;
            public void UpdateQuantity(int value)
            {
                _quantity += value;
                // alert any observers
            }
        }

        class Observer
        {
            ConsoleColor _color;
            public Observer(ConsoleColor color)
            {
                _color = color;
            }
            internal void ObserverQuantity(int quantity)
            {
                Console.ForegroundColor = _color;
                Console.WriteLine($"I observer the new quantity value of {quantity}.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        var subject = new Subject();
        var greenObserver = new Observer(ConsoleColor.Green);
        var redObserver = new Observer(ConsoleColor.Red);
        var yellowObserver = new Observer(ConsoleColor.Yellow);

