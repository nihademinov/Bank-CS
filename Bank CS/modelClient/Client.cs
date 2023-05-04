using Bank_CS.modelGeneralPerson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_CS.modelClient
{
    internal class Client : Person
    {
        private string? _LiveAddress;
        private string? _WorkAddress;

        public Client(string? liveAddress, string? workAddress, string name, string surname, string gender, int age, double salary) : base(name, surname, gender, age, salary)
        {
            _LiveAddress = liveAddress;
            _WorkAddress = workAddress;
        }

        public string Property_LiveAddress
        {
            get { return _LiveAddress; }
            set { _LiveAddress = value; }
        }

        public string Property_WrokAddress
        {
            get { return _WorkAddress; }
            set { _WorkAddress = value; }
        }

        
    }
}
