using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

using serviceToHost = SkoleSystemService;


namespace SkoleSystemHost {

    public class Program {


        // Host the service within this EXE console application.
        public static void Main() {
            using (ServiceHost serviceHost = new ServiceHost(typeof(serviceToHost.SkoleSystemService))) {
                try {
                    // Open the ServiceHost to start listening for messages.
                    serviceHost.Open();
                    DisplayHostInfo(serviceHost);

                    // The service can now be accessed.
                    Console.WriteLine("*------------------------------------*");
                    Console.WriteLine();
                    Console.WriteLine("Servicen er klar til brug..");
                    Console.WriteLine("Tryk <ENTER> for at stoppe servicen..");
                    Console.WriteLine();
                    Console.WriteLine("*------------------------------------*");
                    
                    Console.ReadLine();

                    // Close the ServiceHost.
                    serviceHost.Close();
                } catch (TimeoutException timeProblem) {
                    Console.WriteLine(timeProblem.Message);
                    Console.ReadLine();
                } catch (CommunicationException commProblem) {
                    Console.WriteLine(commProblem.Message);
                    Console.ReadLine();
                }
            }

        }
        public static void DisplayHostInfo(ServiceHost host) {
            Console.WriteLine();
            Console.WriteLine("*-- Host info --*");

            foreach (System.ServiceModel.Description.ServiceEndpoint se in host.Description.Endpoints) {
                Console.WriteLine();
                Console.WriteLine($"Address: {se.Address}");
                Console.WriteLine($"Binding: {se.Binding.Name}");
                Console.WriteLine($"Contract: {se.Contract.Name}");
                Console.WriteLine("Dette er deparments: ");
                Console.WriteLine();
            }
        }
    }
}
