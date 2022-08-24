using Microsoft.AspNetCore.Mvc;
using SpyDuh_Batman.Models;
using SpyDuh_Batman.Interfaces;
using SpyDuh_Batman.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpyDuh_Batman.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        private IUserRepository _userRepository;

        // GET: api/<UserController>
        [HttpGet]
        public List<User>? Get()
        {
            return _userRepository.GetAll();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public User? Get(int id)
        {
            return _userRepository.GetUserById(id);
        }

        [HttpGet]
        public List<User>? Get(string skill)
        {
            return _userRepository.GetUsersBySkills(skill);
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
    }
}
