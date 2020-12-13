using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3_Repository
{
    public class BadgeRepository
    {
        private Dictionary<int, List<string>> _badgeDictionary = new Dictionary<int, List<string>>();
        //private Dictionary<int, string> _badgeDictionary = new Dictionary<int, string>();
        //key,value

        //Create new badge
        public void CreateNewBadge(BadgeClass badge)
        {
            _badgeDictionary.Add(badge.BadgeID, badge.DoorNames);
        }

        //Read list with badge numbers and door access
        public Dictionary<int, List<string>> ViewAllBadgesAndDoorAccess()
        {
            return _badgeDictionary;
        }

        //Update doors on existing badge

        //Add doors

        //Delete doors from existing badge

        /*public bool RemoveDoorAccess()
        {

        }*/

        //GetBadgeById
    }
}
