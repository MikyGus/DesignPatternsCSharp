using System.Linq;

namespace ProxyPattern
{
    internal class ProtectionProxy : Subject
    {
        Subject _subject;
        private readonly String _currentUser;
        private readonly string[] _registeredUsers;

        public ProtectionProxy(string currentUser)
        {
            _registeredUsers = new string[] { "Admin", "Clint", "Kate" };
            _currentUser = currentUser;
        }
        public override void DoSomeWork()
        {
            Console.WriteLine($"{_currentUser} wants to access into the system.");
            if (_registeredUsers.Contains(_currentUser))
            {
                Console.WriteLine($"Welcome, {_currentUser}");
                if (_subject == null)
                {
                    _subject = new ConcreteSubject();
                }
                _subject.DoSomeWork();
            }
            else
            {
                Console.WriteLine($"Sorry {_currentUser}, you do not have access to the system.");
            }
        }
    }
}
