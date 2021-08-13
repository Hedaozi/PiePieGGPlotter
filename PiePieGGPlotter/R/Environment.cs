using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RDotNet;

namespace CutePie_ggplot2Plotter.R
{
    class Environment
    {
        public static void GetRVersions()
        {
            REngine rEngine = REngine.GetInstance();
        }
    }
}
