namespace SpyDuh_Batman.Models
{
    public class Skill
    {
        public Skill(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool isExpert { get; set; }

    }
}
