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
            ClaimClass claimsFromClaimQueue = claimRepo.GetClaimByClaimID("1");

            Assert.IsNotNull(claimsFromClaimQueue);
        }

        [TestMethod]
        public void DeleteFirstQueueItem_ShouldReturnTrue()
        {
            //Arrange
            ClaimClass claim = new ClaimClass();
            ClaimRepository claimRepo = new ClaimRepository();

            //Act
            claimRepo.CreateNewClaim(claim);
            bool deleteFirstQueueItem = claimRepo.RemoveFirstItemFromQueue();

            //Assert
            Assert.IsTrue(deleteFirstQueueItem);
        }

    }

}
