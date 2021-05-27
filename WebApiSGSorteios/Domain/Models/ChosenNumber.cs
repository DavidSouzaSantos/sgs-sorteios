namespace Domain.Models
{
    public class ChosenNumber
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public bool IsPaid { get; set; }
        public Client Client { get; set; }
        public Sortition Sortition { get; set; }
    }
}
