using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelterProject
{
    class TypeAndDietClass:VirtualPet
    {
        public string PetTypeCat { get; set; }
        public string PetTypeDog { get; set; }
        public string PetTypeBird { get; set; }
        public string PetDietCat { get; set; }
        public string PetDietDog { get; set; }
        public string PetDietBird { get; set; }
        
    }
}
