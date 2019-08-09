using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldWebAPI.Models;

namespace HelloWorldConsoleApplication.Services
{   
    public interface IHelloWorldWebService
    {
        //Get Data from Web API project
        //Data model contains data
        Data GetData();        
    }
}
