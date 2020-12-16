using Challenge2_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Challenge2_UnitTest
{
    [TestClass]
    public class KomodoClaimsTests
    {
        [TestMethod]
        public void CreateNewClaim_ShouldNotGetNull()
        {
            //Arrange
            ClaimRepository claimRepo = new ClaimRepository();
            DateTime claimIncidentDate = new DateTime(2020, 12, 10);
            ClaimClass addedClaim = new ClaimClass("123", ClaimType.Car, "Rear-ended", "$1000", claimIncidentDate, claimIncidentDate, true);
            
            //Act
            claimRepo.CreateNewClaim(addedClaim);
            Queue<ClaimClass> claimsFromClaimQueue = claimRepo.ViewAllClaims();

            //Assert
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

        //ViewAllClaims
        [TestMethod]
        public void ViewAllClaims_IsNotNull()
        {
            //Arrange
            ClaimRepository claimRepo = new ClaimRepository();

            //Act
            Queue<ClaimClass> claimsQueue = claimRepo.ViewAllClaims();

            //Assert
            Assert.IsNotNull(claimsQueue);
        }

        //ViewFirstItem
        [TestMethod]
        public void ViewFirstItem()
        {
            //Arrange
            ClaimRepository claimRepo = new ClaimRepository();
            DateTime claimIncidentDate = new DateTime(2020, 12, 10);
            ClaimClass addedClaim = new ClaimClass("123",ClaimType.Car, "Rear-ended","$1000", claimIncidentDate, claimIncidentDate, true);
            claimRepo.CreateNewClaim(addedClaim);

            //Act
            ClaimClass viewFirstItem = claimRepo.ViewFirstItem();

            //Assert
            Assert.AreEqual(addedClaim, viewFirstItem);
        }

    }

}
