﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Subject : ISubject<IObserver>
    {
        public string SubjectState { get; private set; }
        public List<IObserver> Observers { get; set; } = new();

        public void Attach(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void Detach(IObserver observer)
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
