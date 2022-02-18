using System.Collections.Generic;

namespace VirtualPetMVC.Models
{
    public class Species
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Pet> Pets { get; set; }
    }
}
