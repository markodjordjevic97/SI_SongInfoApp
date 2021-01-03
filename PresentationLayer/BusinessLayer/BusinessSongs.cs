using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    class BusinessSongs
    {
        private readonly AdminRepository adminRepository;
        public BusinessSongs()
        {
            adminRepository = new AdminRepository();
        }
    }
}
