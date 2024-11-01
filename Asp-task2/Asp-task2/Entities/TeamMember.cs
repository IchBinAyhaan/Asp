namespace Asp_task2.Entities
{
    public class TeamMember : BaseEntity
    {
        public string Name { get; set; }
        public string? Surname { get; set; }
        public string Photopath { get; set; }
        public string Position { get; set;}
    }
}
