using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turjumaan
{
    class Settings
    {
        public static int LittleServingCount = 10;
        public static int MaxServingCount = 50;
        public static string Lang = "both";
        public static string DataPath = "C:\\";
        public static double deltaUp = 1;
        public static double deltaDown = 0.5;     
        
        public static string version = "beta " + System.Reflection.Assembly.GetExecutingAssembly() .GetName() .Version .ToString();
    }
}
