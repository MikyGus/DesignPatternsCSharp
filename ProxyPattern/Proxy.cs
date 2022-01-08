using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    internal class Proxy : Subject
    {
        Subject _subject;
        public override void DoSomeWork()
        {
            Console.WriteLine("Welcome, my client.");
            if (_subject == null)
            {
                _subject = new ConcreteSubject();
            }
            _subject.DoSomeWork();
        }
    }
}
