using SpyDuh_Batman.Models;
using SpyDuh_Batman.Interfaces;

namespace SpyDuh_Batman.Repositories
{
    public class UserRepository : IUserRepository
    {
        private static List<User> _userData = new List<User>()
        {
          new User()
        {
            Id = 1,
            CodeName = "Spiffy",
            Friends = new List<int>()
            {
                3,2
            },
            Enemies = new List<int>()
            {
                4
            },
            Skills = new List<string>()
            {
                "guns", "explosions", "C#"
            },
            HasSideKick = true
        },
          new User()
        {
            Id = 2,
            CodeName = "Blimpo",
            Friends = new List<int>()
            {
                1,3
            },
            Enemies = new List<int>()
            {
                4
            },
            Skills = new List<string>()
            {
                "knives", "cooking", "JavaScript"
            },
            HasSideKick = false
        },
          new User()
        {
            Id = 3,
            CodeName = "Elsa",
            Friends = new List<int>()
            {
                1,2
            },
            Enemies = new List<int>()
            {
                4
            },
            Skills = new List<string>()
            {
                "Ice", "Singing", "Python"
            },
            HasSideKick = true

        },
          new User()
        {
            Id = 4,
            CodeName = "Kris",
            Friends = new List<int>()
            {

            },
            Enemies = new List<int>()
            {
                1,2,3
            },
            Skills = new List<string>()
            {
                "guns", "knives", "Python"
            },
            HasSideKick = false
        }
        };

        public List<User> GetAll()
        {
            return _userData;
        }

        public User? GetUserById(int id)
        {
            return _userData.FirstOrDefault(u => u.Id == id);
        }

        public List<User>? GetUsersBySkills(string skill)
        {
            return _userData.FindAll(spy => spy.Skills.Contains(skill));
        }

        public List<User>? GetUsersByFriendship(int Id)
        {
            return _userData.FindAll(spy => spy.Friends.Contains(Id));
        }

        public List<User>? GetUsersByEnemies(int Id)
        {
            return _userData.FindAll(spy => spy.Enemies.Contains(Id));
        }

        public void CreateUser(User user)
        {
            _userData.Add(user);
        }
    }
}
