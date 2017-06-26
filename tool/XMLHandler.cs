using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PlanetPlacementTool.tool
{
    public class XMLHandler
    {
        public IList<Planet> DeserializeXMLFilesPlanets(PlanetPlacementProject Current_PPProject)
        {
            IList<Planet> planetCollection = new List<Planet>();
            foreach (string xmlPlanetFile in Current_PPProject.PlanetsXMLPaths)
            {
                XDocument document = XDocument.Load(xmlPlanetFile);
                foreach (XElement element in document.Root.Elements())
                {
                    if (element.Name == "Planet")
                    {
                        if (element.Attribute("Name").Value != "Galaxy_Core_Art_Model")
                        {
#if DEBUG
                            string pName, pGalacticPos = "Null";
                            pName = element.Attribute("Name").Value;
                            Console.WriteLine("{0} {1}", element.Name, pName);
                            foreach (XElement planet_element in element.Elements())
                            {
                                if (planet_element.Name == "Galactic_Position")
                                {
                                    pGalacticPos = planet_element.Value;
                                    Console.WriteLine("    {0}: {1}\n", planet_element.Name, pGalacticPos);
                                }
                                    
                            }
#else
                            string pName, pGalacticPos = "Null";
                            pName = element.Attribute("Name").Value;
                            foreach (XElement planet_element in element.Elements())
                            {
                                if (planet_element.Name == "Galactic_Position")
                                {
                                    pGalacticPos = planet_element.Value;
                                }
                                    
                            }
#endif
                            if (pName != "Null" && pGalacticPos != "Null")
                            {
                                Planet nPlanet = new Planet(pName, pGalacticPos);
                                planetCollection.Add(nPlanet);
#if DEBUG
                                string output = JsonConvert.SerializeObject(nPlanet, Formatting.Indented);
                                Console.Write($"{output}\n");
#endif
                            }
                        }
                    }

                }
            }
            return planetCollection;
        }
    }
}
