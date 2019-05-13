using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace myMicroservice.Model
{
    public class XmlConverter
    {
        public XDocument GetXML()
        {
            var xDocument = new XDocument();
            var xElement = new XElement("CarManufacturers");
            var xAttributes = CarManufacturerDataProvider.GetData()
                .Select(m => new XElement
                    (
                        "CarManufacturer",
                        new XAttribute("City", m.City),
                        new XAttribute("Country", m.Country),
                        new XAttribute("Name", m.Name),
                        new XAttribute("Founding Year", m.FoundingYear)
                    )
                );

            xElement.Add(xAttributes);
            xDocument.Add(xElement);

            //Console.WriteLine(xDocument);

            return xDocument;
        }
    }
}
