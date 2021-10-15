using System;
using System.Collections.Generic;

namespace WebExample.Models
{
    public partial class Human
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public int? CarsId { get; set; }


        //Only for representation. a separate class will be created which will inherit from Human.cs
       // public virtual Car? Cars { get; set; }
    }
}
