using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_6
{
    public class Client
    {
        public string Name { get; }
        public Account Account { get; }

        public Client(string name, string accountNumber, string password)
        {
            Name = name;
            Account = new Account(accountNumber, password);
        }
    }
}
