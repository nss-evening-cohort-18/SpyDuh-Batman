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

        [HttpGet("/users")]
        public List<User>? GetUsers(string skill)
        {
            return _userRepository.GetUsersBySkills(skill);
        }

        [HttpGet("/friends")]
        public List<User>? GetFriends(int id)
        {
            return _userRepository.GetUsersByFriendship(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public void PostUser(User user)
        {
            _userRepository.CreateUser(user);
        }

        // PUT api/<UserController>/5
        [HttpPut("/user/skill")]
        public void PutSkill(int id, string skill)
        {
            _userRepository.AddSkill(id, skill);
        }

        [HttpPut("/user/friend")]
        public void PutFriend(int userId, int friendId)
        {
            _userRepository.AddFriend(userId, friendId);
        }

        [HttpPut("/user/enemy")]
        public void PutEnemy(int userId, int enemyId)
        {
            _userRepository.AddEnemy(userId, enemyId);
        }
        [HttpDelete("/user/skill")]
        public void DeleteSkill(int id, string skill)
        {
            _userRepository.DeleteSkill(id, skill);
        }
    }
}
