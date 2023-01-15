using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Observer : IObserver
    {
        public Observer(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        private string ObserverState { get; set; } = "";
        public void Update(string SubjectState)
        {
            ObserverState = SubjectState;
            Console.WriteLine($"{Name} : observerState update = {SubjectState} ");
        }

    }
}
