﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using smsapi.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace smsapi.Controllers
{
    [Route("api/[controller]")]
    public class OperationController : ControllerBase
    {
        private readonly IUserManagementServices _userManagementServices;
        private readonly IWebHostEnvironment _env;
        private readonly IConfiguration _configuration;

        public OperationController(IUserManagementServices userManagementServices, IWebHostEnvironment env, IConfiguration configuration)
        {
            _userManagementServices = userManagementServices;
            _env = env;
            _configuration = configuration;
        }
        // GET: api/values
        [HttpGet("getStudentDetails")]
        public IActionResult GetAllStudents()
        {
            object response = _userManagementServices.GetAllStudents();
            if(response.ToString() != null)
            {
                return Ok(response);
            }
            else
            {
                return BadRequest("Failed to get Details");
            }
        }

        // GET: api/values
        //[HttpGet("test")]
        
        //public IActionResult Test()
        //{
        //    object res = _userManagementServices.Test();
        //    if(res.ToString() != null)
        //    {
        //           return Ok(res);
        //    }
        //    else
        //    {
        //        return BadRequest(res);
        //    }
        //}


    }
}
