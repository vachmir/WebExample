using System;
using System.Collections.Generic;

namespace WebExample.Models
{
    public partial class TestPerson
    {
        public TestPerson()
        {
            Pairs = new HashSet<Pair>();
        }

        public int PersonId { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public int? FkcarId { get; set; }

        public virtual TestCar? Fkcar { get; set; }
        public virtual ICollection<Pair> Pairs { get; set; }
    }
}
