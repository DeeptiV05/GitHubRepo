using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HelloWorldWebAPI.Models;

namespace HelloWorldWebAPI.Services
{
    public interface IDataService
    {
        Data GetData();
    }
}