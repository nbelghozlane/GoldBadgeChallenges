using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2_Repository
{
    public class ClaimRepository
    {
        //private List<ClaimClass> _listOfClaims = new List<ClaimClass>();
        private Queue<ClaimClass> _claimQueues = new Queue<ClaimClass>(); 

        //Create
        public void CreateNewClaim(ClaimClass claim)
        {
            _claimQueues.Enqueue(claim);
            //_listOfClaims.Add(claim);
        }

        //Read
        public Queue<ClaimClass> ViewAllClaims()
        {
            return _claimQueues;
           //return _listOfClaims;
        }

        //Update

        //Delete
        public void RemoveFirstItemFromQueue()
        {
            _claimQueues.Dequeue();
        }

        //ViewNextClaim
        public ClaimClass ViewFirstItem()
        {
            return _claimQueues.Peek();
        }
    }
}
