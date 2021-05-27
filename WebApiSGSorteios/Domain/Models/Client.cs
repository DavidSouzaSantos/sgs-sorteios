using System.Collections.Generic;

namespace Domain.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FoneNumber { get; set; }
        public List<ChosenNumber> ChosenNumbers { get; set; }
    }
}
