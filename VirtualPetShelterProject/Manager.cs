using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelterProject
{
    class Manager : Employee
    {
        public bool AdoptionStatus;
        public override void NewEmployee()
        {
            throw new NotImplementedException();
        }

        public override void FormerEmployee()
        {
            throw new NotImplementedException();
        }

        public bool Adoption()
        {
            return AdoptionStatus;
        }
    }
}
