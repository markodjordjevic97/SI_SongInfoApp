using BusinessLayer;
using DataAccessLayer;
using DataAccessLayer.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BusinessLayerTests
{
    [TestClass]
    public class BusinessAdminTests
    {
        BusinessAdmin businessAdmin;

        [TestInitialize]
        public void SetData()
        {
            businessAdmin = new BusinessAdmin();
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            businessAdmin.DeleteAdmin(new Admin()
            {
                Username = "ivankrstic"
            });
        }

        [TestMethod]
        public void IsAdminValidRegistered()
        {
            //Arrange
            var admin = new Admin()
            {
                Name = "Ivan",
                Surname = "Krstic",
                Username = "ivankrstic",
                Password = "Ikrstic123456"
            };

            //Act
            int result = businessAdmin.RegisterAdmin(admin);

            //Assert
            Assert.AreEqual(1, result);
        }
    }
}
