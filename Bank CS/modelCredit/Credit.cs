using Bank_CS.modelClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_CS.modelCredit
{
    internal class Credit:ICalculate
    {
        private double _Amount;
        private Guid _Id;
        private int _Month;
        private Client _Client;
        private double _Percent;

        public Credit(double amount, int month, Client client, double percent)
        {
            _Amount = amount;
            _Id = Guid.NewGuid();
            _Month = month;
            _Client = client;
            _Percent = percent;
        }

        public double Property_Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }

        public Guid Property_Id
        {
            get { return _Id; }
        }
        public Client Property_Client
        {
            get { return _Client; }
            set { _Client = value; }
        }

        public int Property_Month
        {
            get { return _Month; }
            set
            {
                if (value < 0 && value >= 12)
                    _Month = value;
                else
                {
                    try
                    {
                        throw new Exception("Wrong month");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

            }
        }
        public double Property_Percent
        {
            get { return _Percent; }
            set
            {
                if (value < 0)
                {
                    try
                    {
                        throw new Exception("Percent can not be negative");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                    _Percent = value;
            }
        }

        public void Calculate()
        {
            double TotalAmount = _Amount * _Percent / 100 + _Amount;
            double MonthAmount = _Amount / _Month;
            Console.WriteLine($"You will pay:{MonthAmount} AZN");
        }
    }
}
