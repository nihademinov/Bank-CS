using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_CS.modelGeneralPerson
{
    internal class Person
    {
        private string _Name;
        private string _Surname;
        private string _Gender;
        private int _Age;
        private double _Salary;
        private Guid _Id;

        public Person(string name, string surname, string gender, int age, double salary)
        {
            _Name = name;
            _Surname = surname;
            _Gender = gender;
            _Age = age;
            _Salary = salary;
            _Id = Guid.NewGuid();
        }

        public string Property_Name
        {
            get { return _Name; }
            set
            {
                if (value.Length < 1)
                {
                    try
                    {
                        throw new Exception("Name Length can not be short than two symbols");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        _Name = " ";
                    }
                }
                else
                    _Name = value;
            }
        }

        public string Property_Surname
        {
            get { return _Surname; }
            set
            {
                if (value.Length < 1)
                {
                    try
                    {
                        throw new Exception("Surname Length can not be short than two symbols");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        _Name = " ";
                    }
                }

                _Surname = value;
            }
        }

        public string Property_Gender
        {
            get { return _Gender; }
            set
            {
                value = value.ToLower();
                if (value != "male" || value != "female")
                {
                    try
                    {
                        throw new Exception("Uncorrect gender type");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        _Gender = " ";
                    }
                }
                else
                    _Gender = value;
            }
        }

        public int Property_Age
        {
            get { return _Age; }
            set
            {
                if (value < 17)
                {
                    try
                    {
                        throw new Exception("You must be older than 18");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                    _Age = value;
            }
        }

        public double Property_Salary
        {
            get { return _Salary; }
            set
            {
                if (value < 0)
                {
                    try
                    {
                        throw new Exception("Salary can not be negative");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                    _Salary = value;
            }
        }

        public Guid Property_ID
        {
            get { return _Id; }
        }

    }
}
