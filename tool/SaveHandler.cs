using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetPlacementTool.tool
{
    class SaveHandler
    {
        public SaveHandler()
        {

        }
        public void SaveToFile(string path, string filename, string content)
        {
            string filepath = path + "\\" + filename + ".yvaw-pptp";
#if DEBUG
            Console.Write("Saving to {0}\n", filepath);
#endif
            System.IO.File.WriteAllText(@filepath, content);
            tool.Global.PROJECT_DIRTY_ = false;
        }
    }
}
