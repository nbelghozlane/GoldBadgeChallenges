using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2_Repository
{
    public class ClaimRepository
    {
        private Queue<ClaimClass> _claimQueues = new Queue<ClaimClass>(); 

        //Create
        public void CreateNewClaim(ClaimClass claim)
        {
            _claimQueues.Enqueue(claim);
        }

        //Read
        public Queue<ClaimClass> ViewAllClaims()
        {
            return _claimQueues;
        }

        //Delete
        public bool RemoveFirstItemFromQueue()
        {
            int initialCount = _claimQueues.Count;
            
            _claimQueues.Dequeue();

            if (initialCount > _claimQueues.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //ViewNextClaim
        public ClaimClass ViewFirstItem()
        {
            return _claimQueues.Peek();
        }
    }
}

