using System;
using System.Collections.Generic;

namespace WebExample.Models
{
    public partial class Car
    {
        public Car()
        {
            Humans = new HashSet<Human>();//Foreigh key տվողն այսպիսի՞ն է
        }

        public int Id { get; set; }
        public string? Model { get; set; }
        public string? SerialNumber { get; set; }

        public virtual ICollection<Human> Humans { get; set; }
    }
}
