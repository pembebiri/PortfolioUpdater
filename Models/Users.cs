public class Users
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Pass { get; set; }

    public ICollection<UserSkill> UserSkills { get; set; }
    public ICollection<Project> Projects { get; set; }
}