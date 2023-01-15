using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface ISubject<T> where T : IObserver
    {
        public List<T> Observers { get; set; }
        public void Attach(T observer);
        public void Detach(T observer);
        public void Notify();
    }
}
