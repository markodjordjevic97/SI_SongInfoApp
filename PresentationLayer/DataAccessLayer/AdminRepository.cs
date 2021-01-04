using DataAccessLayer.Models;
using System;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public class AdminRepository
    {
        private List<Admin> list = new List<Admin>();
        public int RegisterAdmin(Admin admin)
        {
            return 2;
        }
        public bool IsUidAvailable(Admin admin)
        {
            return true;
        }


    }
}
