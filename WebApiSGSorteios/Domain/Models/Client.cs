using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FoneNumber { get; set; }
        public List<ChosenNumber> chosenNumbers { get; set; }
    }
}
