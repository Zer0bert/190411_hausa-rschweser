using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myMicroservice.Model
{
/// <summary>
/// Xml To Json Adapter
/// </summary>
public class XmlToJsonAdapter : IXmlToJson
{
    private readonly XmlConverter _xmlConverter;

    public XmlToJsonAdapter(XmlConverter xmlConverter)
    {
        _xmlConverter = xmlConverter;
    }

    public void ConvertXmlToJson()
    {
        var manufacturers = _xmlConverter.GetXML()
            .Element("CarManufacturers")
            .Elements("CarManufacturer")
            .Select(m => new CarManufacturer
            {
                City = m.Attribute("City").Value,
                Country = m.Attribute("Country").Value,
                Name = m.Attribute("Name").Value,
                FoundingYear = Convert.ToInt32(m.Attribute("FoundingYear").Value)
            });

        new JsonConverter(manufacturers)
            .ConvertToJson();
    }
}
}
