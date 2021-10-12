using System;
using System.Collections.Generic;

namespace WebExample.Models
{
    public partial class Human
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public string? Email { get; set; }
        public string? City { get; set; }
        public int? CarsId { get; set; }


        //Only for representation. a separate class will be created which will inherit from Human.cs
        public virtual Car? Cars { get; set; }
    }
}
