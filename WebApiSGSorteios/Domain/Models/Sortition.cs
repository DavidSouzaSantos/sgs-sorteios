using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    class Sortition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public User User { get; set; }
    }
}
