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
                if (System.IO.File.Exists(xmlPlanetFile))
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
                else
                {
                    System.Windows.Forms.MessageBox.Show("The requested planet file could not be loaded!\n Please make sure that a the file exists in this position:\n" + xmlPlanetFile, "Error!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }
            }
            return planetCollection;
        }
        public void UpdatePlanetXMLFiles(PlanetPlacementProject Current_PPProject)
        {
            foreach (string xmlPlanetFile in Current_PPProject.PlanetsXMLPaths)
            {
                if (System.IO.File.Exists(xmlPlanetFile))
                {
                    XDocument document = XDocument.Load(xmlPlanetFile);
                    foreach (XElement element in document.Root.Elements())
                    {
                        if (element.Name == "Planet")
                        {
                            foreach (Planet pl in Current_PPProject.ProjActivePlanets)
                            {
                                if (element.Attribute("Name").Value == pl.Name)
                                {
#if DEBUG
                                    string pGalacticPos = "Null";
                                    foreach (XElement planet_element in element.Elements())
                                    {
                                        if (planet_element.Name == "Galactic_Position")
                                        {
                                            pGalacticPos = planet_element.Value;
                                            planet_element.Value = pl.V3ToGalacticPos();
                                            break;
                                        }
                                    }
                                    Console.Write("Found Planet {0}, updating galactic coordinates from {1} to {2}.\n", element.Attribute("Name").Value, pGalacticPos, pl.V3ToGalacticPos());
#else
                                    foreach (XElement planet_element in element.Elements())
                                    {
                                        if (planet_element.Name == "Galactic_Position")
                                        {
                                            planet_element.Value = pl.V3ToGalacticPos();
                                            break;
                                        }
                                    }
#endif
                                }
                            }
                        }
                    }
                    document.Save(@xmlPlanetFile);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("The requested planet file could not be written to!\n Please make sure that a the file exists in this position and it'S writable:\n" + xmlPlanetFile, "Error!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }
            }
        }
    }
}
