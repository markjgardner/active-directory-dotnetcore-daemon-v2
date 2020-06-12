using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TodoList_WebApi.Models;

namespace TodoList_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        // In-memory TodoList
        private static readonly Dictionary<int, TodoItem> TodoStore = new Dictionary<int, TodoItem>();

        // GET: api/todolist
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello World");
        }
    }
}