using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Starex.DAL;
using Starex.Models;
using Starex.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Starex.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly AppDbContext _context;
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,
           RoleManager<IdentityRole> roleManager,AppDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            ViewBag.BranchAddress = _context.Branches.Where(b => b.IsMain == false).ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM register,int BranchAddressId,string gender)
        {
            ViewBag.BranchAddress = _context.Branches.Where(b => b.IsMain == false).ToList();

            if (!ModelState.IsValid) return View();
            AppUser newUser = new AppUser
            {   UserName=register.UserName,
                Surname = register.Surname,
                PhoneNumber = register.Phone,
                Email = register.Email,
                Age=register.Age,
                CardSeria=register.CardSeria,
                CardFinCode=register.CardFinCode,
                Address=register.Address,
                Gender=gender
          
            };
            if (BranchAddressId == null)
            {
                ModelState.AddModelError("Branch","Zehmet olmasa unvani secin!");
                return View();
            }
            newUser.BranchId = BranchAddressId;
            IdentityResult identityResult = await _userManager.CreateAsync(newUser, register.Password);
            if (!identityResult.Succeeded)
            {

                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(register);
            }
            await _userManager.AddToRoleAsync(newUser, "Member");
            await _signInManager.SignInAsync(newUser, true);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Login()
        {
            return View();
        }
        //public async Task CreateRole()
        //{
        //    if (!await _roleManager.RoleExistsAsync("Admin"))
        //    {
        //        await _roleManager.CreateAsync(new IdentityRole { Name = "Admin" });

        //    }
        //    if (!await _roleManager.RoleExistsAsync("Member"))
        //    {
        //        await _roleManager.CreateAsync(new IdentityRole { Name = "Member" });

        //    }
        //}
    }
}
