using Bank_CS.modelGeneralPerson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_CS.modelMenecer
{
    internal class Menecer : Person
    {
        private string? _Position;

        public Menecer(string? position, string name, string surname, string gender, int age, double salary) : base(name, surname, gender, age, salary)
        {
            _Position = position;
        }

        public string Property_Position
        {
            get { return _Position; }
            set { _Position = value; }
        }

    }
}
