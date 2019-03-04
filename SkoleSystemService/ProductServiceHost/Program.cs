using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using serviceToHost = ProductService;

namespace ProductServiceHost {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Console based host");

            using (ServiceHost serviceHost = new ServiceHost(typeof(serviceToHost.ProductService))) {
                serviceHost.Open();
                DisplayHostInfo(serviceHost);
                //Viser noget info omkring den host man starter op i consolen

                //Bliver ved med at køre servicen, indtil man trykker på en knap
                Console.WriteLine("Servicen er klar.. ");
                Console.WriteLine("Tryk på en vilkårlig knap for at lukke servicen..");

            }
        }
        public static void DisplayHostInfo(ServiceHost host) {
            Console.WriteLine();
            Console.WriteLine("*-- Host info --*");

            foreach (System.ServiceModel.Description.ServiceEndpoint se in host.Description.Endpoints) {
                Console.WriteLine($"Address: {se.Address}");
                Console.WriteLine($"Binding: {se.Binding.Name}");
                Console.WriteLine($"Contract: {se.Contract.Name}");
            }
            Console.WriteLine("*----------------*");
        }
    }
}
