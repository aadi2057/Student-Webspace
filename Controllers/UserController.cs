﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Student_Webspace.Models;
using Student_Webspace.Service.UserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student_Webspace.Controllers
{   
    [ApiController]
    [Route("api/[controller]")]
    public class UserController: ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            
            return Ok(await _userService.GetAllUsers());
        }

        [HttpPost]
        public async Task<IActionResult> AddNewUser(User user)
        {
            //CookieOptions cookieOptions = new CookieOptions();
            //cookieOptions.Expires = DateTime.Now.AddDays(1);
            //cookieOptions.HttpOnly = true;
            //Response.Cookies.Append("MyCookie", "AadityaJha", cookieOptions);
            if (ModelState.IsValid)
            {
                return Ok(await _userService.AddNewUser(user));
            }
            else
            {
                return BadRequest("User was not added! Please enter all fields");
            }
            
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUsers()
        {
            return NotFound("404. Page Not Found!");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAll()
        {
            return Ok(await _userService.DeleteAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            return Ok(await _userService.GetUserById(id));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserById(int id)
        {
            return Ok(await _userService.DeleteUserById(id));
        }
    }
}