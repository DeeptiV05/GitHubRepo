using HelloWorldConsoleApplication.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Please enter your name: ");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"\nThank you {name} for considering this project - {date:d} at {date:t}!");

            //Run main program here
            using (var registry = new ServiceContainer())
            {
                //Register Services here
                //registry.Register<IHelloWorldWebService, HelloWorldWebService>();

                //Call Run method defined in HelloWorldConsoleApp.cs 
            }
        }
    }
}
