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
            BadgeClass addedBadge = new BadgeClass(1234, new List<string>() {"B2"});

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
    }
}


