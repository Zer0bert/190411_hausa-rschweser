using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myMicroservice.Model
{
    public class CarManufacturer
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int FoundingYear { get; set; }
    }
}
