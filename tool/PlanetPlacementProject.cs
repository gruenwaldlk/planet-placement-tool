using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetPlacementTool.tool
{
    public class PlanetPlacementProject
    {
        public string ProjectName { get; set; }
        public IList<string> PlanetsXMLPaths { get; set; }
        public IList<string> TraderoutesXMLPaths { get; set; }
        public string BackgroundImagePath { get; set; }
        public int ProjScaleSetting { get; set; }
        public IList<string> ProjActivePlanets { get; set; }
        public IList<string> ProjActiveTraderoutes { get; set; }

        public PlanetPlacementProject(string newProjectName, string[] newPlanetPaths, string newBackgroundImagePath)
        {
            ProjectName = newProjectName;
            PlanetsXMLPaths = new List<string>();
            TraderoutesXMLPaths = new List<string>();
            ProjActivePlanets = new List<string>();
            ProjActiveTraderoutes = new List<string>();
            foreach (string path in newPlanetPaths)
            {
                PlanetsXMLPaths.Add(path);
            }
            BackgroundImagePath = newBackgroundImagePath;
            ProjScaleSetting = 500;
        }
        public PlanetPlacementProject(string newProjectName,IList<string> newPlanetPaths,IList<string> newTraderoutesXMLPaths,string newBackgroundImagePath,int newProjScaleSetting,IList<string> newProjActivePlanets,IList<string> newProjActiveTraderoutes)
        {
            ProjectName = newProjectName;
            PlanetsXMLPaths = newPlanetPaths;
            TraderoutesXMLPaths = newTraderoutesXMLPaths;
            BackgroundImagePath = newBackgroundImagePath;
            ProjScaleSetting = 500;
            ProjActivePlanets = newProjActivePlanets;
            ProjActiveTraderoutes = newProjActiveTraderoutes;
        }
    }
}
