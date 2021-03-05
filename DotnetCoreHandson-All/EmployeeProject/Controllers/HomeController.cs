﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EmployeeProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace EmployeeProject.Controllers
{

    public class HomeController : Controller
    {


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(GetEmployeeDetails());
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

        public List<Employee> GetEmployeeDetails()
        {
            List<Employee> EmployeeList = new List<Employee>(){

                 new Employee(1,"John",1000,true),
                 new Employee(2,"Smith",5000,false),
                 new Employee(3,"Mark",5000,false),
                 new Employee(4,"Mary",6000,false)

             };


            return EmployeeList;


        }
             
    }
}


    
    

    


