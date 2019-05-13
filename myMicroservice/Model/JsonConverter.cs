using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace myMicroservice.Model
{

    public class JsonConverter
    {
        private IEnumerable<CarManufacturer> _carmanufacturers;

        public JsonConverter(IEnumerable<CarManufacturer> carmanufacturers)
        {
            _carmanufacturers = carmanufacturers;
        }

        public void ConvertToJson()
        {
            var jsonCarManufacturers = JsonConvert.SerializeObject(_carmanufacturers, Formatting.Indented);

            //Console.WriteLine("\nPrinting JSON list\n");
            //Console.WriteLine(jsonManufacturers);
        }
    }
}
