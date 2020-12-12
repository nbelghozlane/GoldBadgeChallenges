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
        public List<BadgeClass> DoorNames { get; set; } = new List<BadgeClass>(); // list<string> ??

        public BadgeClass(int badgeID, List<BadgeClass> doorNames)
        {
            BadgeID = badgeID;
            DoorNames = doorNames;
        }
    }
}
