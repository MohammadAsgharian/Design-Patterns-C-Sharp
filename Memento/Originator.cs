using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Originator
    {
        public Originator()
        {
        }
        string state;
        public string State
        {
            get { return state; }
            set
            {
                state = value;
                Console.WriteLine(state);
            }
        }
        public Memento CreateMemento()
        {
            Console.WriteLine("State Saving.");
            return (new Memento(State));
        }

        public void SetMemento(Memento memento)
        {
            Console.WriteLine("Restoring State.");
            State = memento.State;
        }
    }
}
