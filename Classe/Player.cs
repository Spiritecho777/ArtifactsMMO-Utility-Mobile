using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifactsMMO_Utility_Mobile.Classe
{
    public class Player
    {
        public string PlayerNames { get; set; }
        public string Task { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public bool FFlag { get; set; }
        public bool RFlag { get; set; }
        public bool loopF { get; set; }
        public bool loopR { get; set; }
        public bool isRedF { get; set; }
        public bool isRedR { get; set; }
        public bool AutoSellCheck { get; set; }
    }
}
