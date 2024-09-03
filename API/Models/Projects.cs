public class Projects
{
    public class Project
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }

        // Foreign Key
        public int UserId { get; set; }
        public User User { get; set; }
    }

}