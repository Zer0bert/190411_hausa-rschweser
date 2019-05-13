using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myMicroservice.Model
{
    /// <summary>
    /// Creates list of car manufacturers.
    /// </summary>
    public static class CarManufacturerDataProvider
    {
        public static List<CarManufacturer> GetData() => 
            new List<CarManufacturer>
            {
                new CarManufacturer{City = "Stuttgart", Country = "Germany", Name = "Porsche", FoundingYear = 1931},
                new CarManufacturer{City = "Ingolstadt", Country = "Germany", Name = "Audi", FoundingYear = 1949},
                new CarManufacturer{City = "London", Country = "United Kingdom", Name = "Aston Martin", FoundingYear = 1913},
                new CarManufacturer{City = "Tokio", Country = "Japan", Name = "Mitsubishi Motors", FoundingYear = 1970},
                new CarManufacturer{City = "Dearborn", Country = "United States Of America", Name = "Ford", FoundingYear = 1903},
            };
    }
}
