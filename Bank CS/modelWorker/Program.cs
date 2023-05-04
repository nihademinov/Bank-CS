using Bank_CS.modelCeo;
using Bank_CS.modelClient;

namespace Bank_CS.modelWorker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CEO ceo = new CEO("Senior", "Nihad", "Eminov", "Male", 19, 5000);

            Worker worker = new Worker("Programmer", "Ferid", "Feridli", "Male", 20, 2500);

            Client client = new Client("Nesimi", "Bakixanov", "Kamal", "Kamalli", "male", 50,550);







        }
    }
}