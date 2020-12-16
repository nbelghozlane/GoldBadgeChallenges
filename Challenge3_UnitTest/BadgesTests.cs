using Challenge3_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Challenge3_UnitTest
{
    [TestClass]
    public class BadgesTests
    {
        [TestMethod]
        public void CreateNewBadge_ShouldNotGetNull()
        {
            //Arrange
            BadgeRepository badgeRepo = new BadgeRepository();
            BadgeClass addedBadge = new BadgeClass(1234, new List<string>() { "B2" });

            //Act
            badgeRepo.CreateNewBadge(addedBadge);
            Dictionary<int, List<string>> badgeDictionary = badgeRepo.ViewAllBadgesAndDoorAccess();

            //Assert
            Assert.IsNotNull(badgeDictionary);
        }

        [TestMethod]
        public void ViewAllBadgesAndDoorAccess_IsNotNull()
        {
            //Arrange
            BadgeRepository badgeRepo = new BadgeRepository();

            //Act
            Dictionary<int, List<string>> badgeDictionary = badgeRepo.ViewAllBadgesAndDoorAccess();

            //Assert
            Assert.IsNotNull(badgeDictionary);
        }

        [TestMethod]
        public void UpdateBadge()
        {
            //Arrange
            BadgeRepository _badgeRepo = new BadgeRepository();
            BadgeClass oldBadge = new BadgeClass(1234, new List<string>() { "B2" });
            BadgeClass newBadge = new BadgeClass(1234, new List<string>() { "C2" });
            
            //Act
            _badgeRepo.CreateNewBadge(oldBadge);
            bool updateBadge = _badgeRepo.UpdateBadge(newBadge.BadgeID, newBadge.DoorNames);

            //Assert
            Assert.IsTrue(updateBadge);
        }

        [TestMethod]
        public void RemoveBadge()
        {
            //Arrange
            BadgeClass addedBadge = new BadgeClass(1234, new List<string>() { "B2" });
            BadgeRepository badgeRepo = new BadgeRepository();

            //Act
            badgeRepo.CreateNewBadge(addedBadge);
            bool deleteBadge = badgeRepo.RemoveBadge(addedBadge.BadgeID);

            //Assert
            Assert.IsTrue(deleteBadge);
        }
    }

}


