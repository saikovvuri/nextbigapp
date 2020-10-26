using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Caching.Distributed;
using System.Text.Json;
using System.Threading.Tasks;
using marvel_api.Models;
using Microsoft.EntityFrameworkCore;

namespace marvel_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharactersController : ControllerBase
    {
        private readonly CharacterContext _context;

        private readonly ILogger<CharactersController> _logger;

        public CharactersController(ILogger<CharactersController> logger, CharacterContext context)
        {
            _logger = logger;
            _context = context;
        }

         [HttpGet]
        public async Task<ActionResult<IEnumerable<Character>>> Get()
        {
            return await _context.Characters.ToListAsync();            
        }
    }
}