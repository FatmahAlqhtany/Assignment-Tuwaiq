using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication11.Controllers
{
    public class HelloWorldController : Controller
    {
      public string Index()
        {
            return "Default action";
        }
        public string Welcome(string name)
        {
            return $"welcome {name}";
        }
        
            public string Info(string name,int age)
        {
            return $"welcome {name} your age is {age}";
        }

    }
}
