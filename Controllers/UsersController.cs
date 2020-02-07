using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using C_Sharp_ViewModelFun.Models;

namespace C_Sharp_ViewModelFun.Controllers
{
    public class UsersController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpGet("string")]
        public IActionResult StringNames()
        {
            string[] names = new string[]
            {
                "Sally", "Oli", "Mac", "Misha"
            };
            return View("StringNames", names);
        }

        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] nums = new int[]
            {
                1, 6, 123, 564, 0, 3, 12, 56
            };
            return View("Numbers", nums);
        }



            

        [HttpGet("user")]
        public IActionResult SingleUser()
        {
            Person newPerson = new Person()
            {
                FirstName = "Alex",
                LastName = "Good"
            };
            return View("SingleUser", newPerson);
        }


        [HttpGet("users")]
        public IActionResult Users()
        {
            Person newPerson = new Person()
            {
                FirstName = "Alex",
                LastName = "Good"
            };

            Person new2Person = new Person()
            {
                FirstName = "Marina",
                LastName = "Korol"
            };

            List<Person> personList = new List<Person>
            {
                newPerson, new2Person
            };

            return View("Users", personList);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

}
