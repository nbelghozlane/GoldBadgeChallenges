using Challenge2_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Challenge2_UnitTest
{
    [TestClass]
    public class KomodoClaimsTests
    {
        [TestMethod]
        public void CreateNewClaim_ShouldNotGetNull()
        {
            ClaimClass claim = new ClaimClass();
            claim.ClaimID = "1";
            ClaimRepository claimRepo = new ClaimRepository();

            claimRepo.CreateNewClaim(claim);
            //ClaimClass claimsFromClaimQueue = claimRepo.ViewAllClaims();

            //Assert.IsNotNull(claimsFromClaimQueue);
        }
    }
}
