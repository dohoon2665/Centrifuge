using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using centrifuge.Domain.Entities;
using centrifuge.Domain.Services;
using centrifuge.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace centrifuge.Controllers
{
    [ApiController]
    [Route("door")]
    public class DoorController : ControllerBase
    {
        private readonly IDoorService _doorService;
        private readonly ILogger<DoorController> _logger;

        public DoorController(ILogger<DoorController> logger,
        IDoorService doorService)
        {
            _logger = logger;
            _doorService = doorService;
        }

        [HttpGet("open")]
        public IActionResult OpenDoor()
        {
            var isSuccessful = _doorService.Open();
            if (isSuccessful)
            {
                return Ok(new { status = true });
            }
            else
            {
                return BadRequest(new { Message = "The door is abnormal." });
            }
        }

        [HttpGet("close")]
        public IActionResult CloseDoor()
        {
            var isSuccessful = _doorService.Close();
            if (isSuccessful)
            {
                return Ok(new { status = true });
            }
            else
            {
                return BadRequest(new { Message = "The door is abnormal." });
            }
        }
    }
}
