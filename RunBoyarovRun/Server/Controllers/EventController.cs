using Microsoft.AspNetCore.Mvc;
using RunBoyarovRun.Shared;
using System;
using System.Collections.Generic;

namespace RunBoyarovRun.Server.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class EventController : ControllerBase
    {
        private readonly Event[] Events = new Event[]
        {
            new Event
            {
                Date = DateTime.UtcNow,
                Title = "First Event",
                Description = "Some detailed description here",
                Image = "https://upload.wikimedia.org/wikipedia/commons/1/1c/Beijing_2008%2C_Beijing_National_Stadium.jpg"
            },
            new Event
            {
                Date = DateTime.UtcNow.AddDays(2),
                Title = "Second Event",
                Description = "Some detailed description here",
                Image = "https://upload.wikimedia.org/wikipedia/commons/1/1c/Beijing_2008%2C_Beijing_National_Stadium.jpg"
            }
        };

        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return this.Events;
        }
    }
}
