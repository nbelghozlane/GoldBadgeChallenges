using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3_Repository
{
    public class BadgeClass
    {
        public int BadgeID { get; set; }
        public List<string> DoorNames { get; set; } = new List<string>(); 

        public BadgeClass() { }

        public BadgeClass(int badgeID, List<string> doorNames)
        {
            BadgeID = badgeID;
            DoorNames = doorNames;
        }
    }
}
