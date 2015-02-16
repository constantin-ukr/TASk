using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;
using System.ServiceModel;

using Common;
using T3Service;

namespace Server
{
    class Program
    {
        static ServiceHost T3Host;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Start Server\nDate: "+DateTime.Now);
            Console.ForegroundColor = ConsoleColor.Gray;           

            try
            {
                T3Host =  new ServiceHost(typeof(T3Implementation), new Uri[] {new Uri("http://localhost:5000/T3Service")});
                T3Host.Open();
            }

            catch(Exception ex )
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);

                if (T3Host.State == CommunicationState.Opened)
                    T3Host.Close();
            }

            Console.ReadKey();
        }
    }
}
