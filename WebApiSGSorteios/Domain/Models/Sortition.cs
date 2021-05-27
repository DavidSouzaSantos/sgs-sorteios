namespace Domain.Models
{
    public class Sortition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public User User { get; set; }
    }
}
