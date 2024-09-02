public class Skills
{

        public int Id { get; set; }
        public string Name { get; set; }

        // Relationship
        public ICollection<UserSkill> UserSkills { get; set; }
}