using DataAccessLayer;
using System;

namespace BusinessLayer
{
    public class BusinessAdmin
    {
        private readonly AdminRepository adminRepository;

        public BusinessAdmin()
        {
            adminRepository = new AdminRepository();
        }

    }
}
