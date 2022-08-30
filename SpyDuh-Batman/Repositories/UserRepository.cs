using SpyDuh_Batman.Models;
using SpyDuh_Batman.Interfaces;
using System.Linq;

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
            Skills = new List<Skill>()
            {
                new Skill(1)
                {
                    Name = "explosions",
                    isExpert = true
                },
                new Skill(2)
                {
                    Name = "guns",
                    isExpert = false
                },
                new Skill(3)
                {
                    Name = "C#",
                    isExpert = false
                }
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
            Skills = new List<Skill>()
            {
                
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
            Skills = new List<Skill>()
            {
               
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
            Skills = new List<Skill>()
            {
                
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
            //return _userData.FindAll(spy => spy.Skills.FirstOrDefault(userSkill => userSkill.Name == skill));
            List<User> spysWhithSkill = new();
            foreach (User spy in _userData)
            {
                for (int i = 0; i < spy.Skills.Count; i++)
                {
                    if (spy.Skills[i].Name == skill)
                    {
                        spysWhithSkill.Add(spy);
                    }
                }
            }
            return spysWhithSkill;
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
        public void AddSkill(int id, Skill skill)
        {
            var skillToAdd = _userData.FirstOrDefault(f => f.Id == id);
            skillToAdd.Skills.Add(skill);
        }

        public void AddFriend(int id, int friendId)
        {
            var friendToAdd = _userData.FirstOrDefault(f => f.Id == id);
            friendToAdd.Friends.Add(friendId);
        }

        public void AddEnemy(int id, int enemyId)
        {
            var enemyToAdd = _userData.FirstOrDefault(f => f.Id == id);
            enemyToAdd.Enemies.Add(enemyId);
        }

        public void DeleteSkill(int id, int skillId)
        {
            var currentUser = _userData.FirstOrDefault(user => user.Id == id);
            Skill skillToRemove = currentUser.Skills.FirstOrDefault(skill => skill.Id == skillId);
            currentUser.Skills.Remove(skillToRemove);
        }
    }
}
