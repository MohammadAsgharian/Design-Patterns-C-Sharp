using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Subject : ISubject<Observer>
    {
        public string SubjectState { get; private set; }
        public List<Observer> Observers { get; set; } = new();

        public void Attach(Observer observer)
        {
            Observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            Observers.Remove(observer);
        }
        public void SetSubjectState(string state)
        {
            this.SubjectState = state;
            Notify();
        }

        public void Notify()
        {
            foreach (var observer in Observers)
            {
                observer.Update(SubjectState);
            }
        }
    }
}
