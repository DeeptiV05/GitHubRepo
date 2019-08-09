using HelloWorldWebAPI.Models;
using HelloWorldWebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace HelloWorldWebAPI.Controllers
{
    public class DataController : ApiController
    {
        private readonly IDataService dataService;

        public DataController(IDataService dataService)
        {
            this.dataService = dataService;
        }
        public Data Get()
        {
            return this.dataService.GetData();
        }
    }
}