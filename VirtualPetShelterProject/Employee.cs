using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelterProject
{
    public abstract class Employee
    {
        public int EmployeeNumber { get; set; }

        public abstract void FormerEmployee();


        public abstract void NewEmployee();
        

    }
}
