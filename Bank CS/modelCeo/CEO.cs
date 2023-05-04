using Bank_CS.modelGeneralPerson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_CS.modelCeo
{
    internal class CEO : Person,IOrganize
    {
        private string _Position;

        public CEO(string position, string name, string surname, string gender, int age, double salary) : base(name, surname, gender, age, salary)
        {
            _Position = position;
        }

        public string Property_Position
        {
            get { return _Position; }
            set { _Position = value; }
        }

        public void Organize()
        {
            Console.WriteLine($"We have meeting at {DateTime.Now}.Please dont late");
        }
    }
}
