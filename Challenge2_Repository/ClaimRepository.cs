using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2_Repository
{
    public class ClaimRepository
    {
        private List<ClaimClass> _listOfClaims = new List<ClaimClass>();

        //Create
        public void CreateNewClaim(ClaimClass claim)
        {
            _listOfClaims.Add(claim);
        }

        //Read
        public List<ClaimClass> ViewAllClaims()
        {
            return _listOfClaims;
        }

        //Update?

        //Delete?
    }
}
