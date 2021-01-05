using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class BusinessPerfomer
    {
        private readonly PerformerRepository perfomer;

        public BusinessPerfomer()
        {
            this.perfomer = new PerformerRepository();
        }

        // Method for GetPerfomer
        public Performer GetPerformer(string name, string surname)
        {
            return this.perfomer.GetPerformerId(name, surname);
        }
        // Method for Insert Performer
        public int InsertPerformer(string name, string surname)
        {
            return this.perfomer.InsertPerfomer(name, surname);
        }
    }
}
