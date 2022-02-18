using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using VirtualPetMVC.Models;

namespace VirtualPetMVC.Controllers
{
    
    public class SpeciesController : Controller
    {
        private ApplicationDbContext _context;

        public SpeciesController()
        {
            _context = new ApplicationDbContext();
        }

        
        
    }
}
