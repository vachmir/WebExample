using System;
using System.Collections.Generic;

namespace WebExample.Models
{
    public partial class Pair
    {
        public int Id { get; set; }
        public int? FkpersonId { get; set; }
        public int? FkcarId { get; set; }


        public virtual TestCar? Fkcar { get; set; }
        public virtual TestPerson? Fkperson { get; set; }
    }
}
