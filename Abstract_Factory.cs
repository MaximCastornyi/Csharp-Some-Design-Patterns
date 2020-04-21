public abstract class InventoryCommand
        {
            private readonly bool _isTerminatingCommand;
            internal InventoryCommand(bool commandIsTerminating)
            {
                _isTerminatingCommand = commandIsTerminating;
            }
            public bool RunCommand(out bool shouldQuit)
            {
                shouldQuit = _isTerminatingCommand;
                return InternalCommand();
            }
            internal abstract bool InternalCommand();
        }

        //using
        public class HelpCommand : InventoryCommand
        {
            public HelpCommand() : base(false) { }
            internal override bool InternalCommand()
            {
                Console.WriteLine("USAGE:");
                Console.WriteLine("\taddinventory (a)");
                ...
Console.WriteLine("Examples:");
                ...
return true;
            }
        }

        //or
        internal abstract class NonTerminatingCommand : InventoryCommand
        {
            protected NonTerminatingCommand() : base(commandIsTerminating: false)
            {
            }
        }

    }