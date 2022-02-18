using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using VirtualPetMVC.Models;

namespace VirtualPetMVC.Controllers
{
    [Authorize]
    public class PetController : Controller
    {
        private ApplicationDbContext _context;
        private string GetUserId()
        {
            return _context.Users.Where(u => u.UserName == User.Identity.Name).FirstOrDefault().Id;
        }

        public PetController()
        {
            _context = new ApplicationDbContext();
        }

        
        
    }
}
