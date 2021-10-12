using System;
using System.Collections.Generic;

namespace WebExample.Models
{
    public partial class TestCar
    {
        public TestCar()
        {
            Pairs = new HashSet<Pair>();
            TestPeople = new HashSet<TestPerson>();
        }

        public int CarId { get; set; }
        public string? Model { get; set; }

        public virtual ICollection<Pair> Pairs { get; set; }
        public virtual ICollection<TestPerson> TestPeople { get; set; }
    }
}
