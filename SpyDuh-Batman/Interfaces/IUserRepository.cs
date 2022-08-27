using SpyDuh_Batman.Repositories;
using SpyDuh_Batman.Models;

namespace SpyDuh_Batman.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetAll();
        User? GetUserById(int id);
        List<User>? GetUsersBySkills(string skill);
        List<User>? GetUsersByFriendship(int Id);
        List<User>? GetUsersByEnemies(int Id);
        public void CreateUser(User user);
        public void AddSkill(int id, string skill);
        public void AddFriend(int userId, int friendId);
        public void AddEnemy(int userId, int enemyId);
        void DeleteSkill(int id, string skill);
    }
}
