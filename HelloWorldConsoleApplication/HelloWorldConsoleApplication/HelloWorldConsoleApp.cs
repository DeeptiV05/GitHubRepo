using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldConsoleApplication.Services;

namespace HelloWorldConsoleApplication
{
    public class HelloWorldConsoleApp
    {
        public readonly IHelloWorldWebService helloWorldWebService;

        //Contructor
        public HelloWorldConsoleApp(IHelloWorldWebService helloWorldWebService)
        {
            this.helloWorldWebService = helloWorldWebService;
        }

        //Define the run method
        //This method needs to be called on main console program viz. program.cs
        public void Run(string[] arguments)
        {
            //Get data
            var data = this.helloWorldWebService.GetData();
        }
    }
}
