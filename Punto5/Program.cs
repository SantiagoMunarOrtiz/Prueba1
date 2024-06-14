using System;
using System.ServiceModel;  

namespace YourNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(TestService)))
            {
                host.Open();
                Console.WriteLine("Service is running...");
                Console.WriteLine("Press [Enter] to exit.");
                Console.ReadLine();
                host.Close();
            }
        }
    }
}

