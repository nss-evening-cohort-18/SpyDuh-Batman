namespace SpyDuh_Batman.Models
{
    public class User
    {
        public int Id { get; set; }

        public string CodeName { get; set; }

        public List<int> Friends { get; set; }

        public List<int> Enemies { get; set; }

        public List<Skill> Skills { get; set; }

        public bool HasSideKick { get; set; }

    }
}