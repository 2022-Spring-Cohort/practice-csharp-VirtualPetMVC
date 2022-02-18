using System;
using System.ComponentModel.DataAnnotations;

namespace VirtualPetMVC.Models
{
    public class Pet
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int SpeciesId { get; set; }
        public virtual Species Species { get; set; }
        public int Health { get; set; }
        public int Boredom { get; set; }
        public int Hunger { get; set; }

        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser User { get; set; }

    }
}
