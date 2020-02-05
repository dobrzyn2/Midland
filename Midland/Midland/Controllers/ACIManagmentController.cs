using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Midland.Models;

namespace Midland.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ACIManagmentController : ControllerBase
    {

        private readonly ILogger<ACIManagmentController> _logger;

        private List<ACIGroup> AciGroups;

        public ACIManagmentController(ILogger<ACIManagmentController> logger)
        {
            _logger = logger;

            this.AciGroups = new List<ACIGroup>();
        }

        [HttpGet]
        public IEnumerable<ACIGroup> Get()
        {
            return this.AciGroups;
        }
    }
}
