using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CommanderAPI.Data;
using CommanderAPI.DTOs;
using CommanderAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CommanderAPI.Controllers
{
    // api/commands
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repo;
        private readonly IMapper _mapper;

        public CommandsController(ICommanderRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CammandReadDTO>> GetAllCommands()
        {
            var commands = _repo.GetAllCommands();
            return Ok(_mapper.Map<IEnumerable<CammandReadDTO>>(commands));

        }

        // GET api/commands/5
        [HttpGet("{id}")]
        public ActionResult<CammandReadDTO> GetCommandById(int Id)
        {
            var command = _repo.GetCommandById(Id);
            if (command != null)
            {
                return Ok(_mapper.Map<CammandReadDTO>(command));
            }

            return NotFound();
        }
    }
}