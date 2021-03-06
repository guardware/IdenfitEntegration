﻿using Idenfit.Entegration.Models;
using Idenfit.Entegration.Models.Task;
using Microsoft.AspNetCore.Mvc;

namespace Idenfit.Entegration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskSignalController : Controller
    {
        [HttpPost("TaskCreated")]
        public ClientResult Post([FromBody] TaskCreated signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal TaskCreated"
            };
        }

        [HttpPost("TaskStateChanged")]
        public ClientResult Post([FromBody] TaskStateChanged signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal TaskStateChanged"
            };
        }

        [HttpPost("TaskCompleted")]
        public ClientResult Post([FromBody] TaskCompleted signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal TaskCompleted"
            };
        }

        [HttpPost("TaskFail")]
        public ClientResult Post([FromBody] TaskFail signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal TaskFail"
            };
        }

        [HttpPost("TaskIncident")]
        public ClientResult Post([FromBody] TaskIncident signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal TaskIncident"
            };
        }
    }
}
