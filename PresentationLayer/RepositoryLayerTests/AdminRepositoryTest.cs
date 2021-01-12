using System;
using System.Collections.Generic;
using DataAccessLayer;
using DataAccessLayer.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepositoryLayerTests
{
    [TestClass]
    public class AdminRepositoryTest
    {
        AdminRepository admin;

        [TestInitialize]
        public void SetData()
        {
           this.admin = AdminRepository.Instance;
        }
        [TestCleanup]
        public void TestCleanup()
        {
            this.admin.DeleteAdmin(
                new Admin() { Name = "adminadmin" });
        }


        [TestMethod]
        public void RegistrationAdmin()
        {
            // Arrange
            var adminFake = new Admin(){
                Name = "Korisnik",
                Surname = "Korisnik1",
                Username = "adminadmin",
                Password = "Adminadmin1"
            };
            // Act
            int result = this.admin.RegisterAdmin(adminFake);
            // Assert
            if(result == 1)
             Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GetAdmin()
        {
            // Arrange
            var adminFake = new Admin()
            {
                Name = "Korisnik",
                Surname = "Korisnik1",
                Username = "adminadmin",
                Password = "Adminadmin1"
            };
            // Act
            List<Admin> list = this.admin.GetAdmin();
            // Assert
            Assert.IsNotNull(list);
        }

        [TestMethod]
        public void AuthentificationAdmin()
        {
            // Arrange
            var adminFake = new Admin()
            {
                Name = "Korisnik",
                Surname = "Korisnik1",
                Username = "adminadmin",
                Password = "Adminadmin1"
            };
            // Act
            Admin adm = this.admin.AuthenticateAdmin(adminFake);
            // Assert
            Assert.IsNotNull(adm);
        }
        [TestMethod]
        public void UpdateAdmin()
        {
            // Arrange
            var adminFake = new Admin()
            {
                Name = "Korisnik",
                Surname = "Korisnik1",
                Username = "adminadmin",
                Password = "Adminadmin1",

            };
            // Act
            this.admin.RegisterAdmin(adminFake);
            int result = this.admin.UpdateAdmin(adminFake);
            // Assert
            Assert.AreEqual(1, result);
        } 
    }
}
