using System;
using System.Collections.Generic;

namespace WebExample.Models
{
    public partial class Pair
    {
        public int Id { get; set; }
        public int? FkHumanId { get; set; }
        public int? FkCarId { get; set; }


        public virtual Car? Fkcar { get; set; }
        public virtual Human? Fkperson { get; set; }
    }
}
