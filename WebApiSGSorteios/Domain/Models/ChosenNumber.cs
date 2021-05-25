using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    class ChosenNumber
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public Client Client { get; set; }
        public Sortition Sortition { get; set; }
    }
}
