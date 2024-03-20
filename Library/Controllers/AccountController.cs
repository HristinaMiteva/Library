using Library.Data.Models;
using Library.Models.Account;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;

namespace Library.Controllers
{
    [Authorize] 
    public class AccountController : Controller
    {
        private readonly UserManager<User> userManager;

        private readonly SignInManager<User> signInManager;

        private readonly RoleManager<IdentityRole> roleManager;



        public AccountController(
            UserManager<User> _userManager,
            SignInManager<User> _signInManager,
            RoleManager<IdentityRole> roleManager)
        {
            userManager = _userManager;
            signInManager = _signInManager;
            this.roleManager = roleManager;
            this.CreateRoles();
        }



        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public IActionResult MakeRole()
        {
            return View();
        }
        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> MakeRole(IdentityRole model)
        {
            if (!roleManager.RoleExistsAsync(model.Name).GetAwaiter().GetResult())
            {
                roleManager.CreateAsync(new IdentityRole(model.Name)).GetAwaiter().GetResult();
            }
            return RedirectToAction("MakeRole");
        }
   
        private async Task CreateRoles()
        {
            if (this.roleManager.Roles.Count() == 0)
            {
                await roleManager.CreateAsync(new IdentityRole() { Name = "Reader" });
                await roleManager.CreateAsync(new IdentityRole() { Name = "Writer" });
                await roleManager.CreateAsync(new IdentityRole() { Name = "Redactor" });
                await roleManager.CreateAsync(new IdentityRole() { Name = "Administrator" });
            }

        }


        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Delete(string id)
        {
            IdentityRole role = await roleManager.FindByIdAsync(id);
            if (role != null)
            {
                IdentityResult result = await roleManager.DeleteAsync(role);
                if (result.Succeeded)
                    return RedirectToAction("Index");
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "No role found");
            }
            return View("Index", roleManager.Roles);
        }



        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Home", "Index");
            }

            var model = new RegisterViewModel();
            ViewBag.RolesId = new SelectList(roleManager.Roles, "Name", "Name");

            return View(model);
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = new User()
            {
                Email = model.Email,
                UserName = model.UserName,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Age = model.Age
            };
            ViewBag.RolesList = roleManager.Roles;
            var result = await userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                await userManager.AddClaimAsync(user, new Claim("email", user.Email));
                if (model.Email == "hristina0404@gmail.com")
                {
                    await userManager.AddToRoleAsync(user, "Administrator");
                }
                else
                {
                    await userManager.AddToRoleAsync(user, model.Role);
                }
                await signInManager.SignInAsync(user, isPersistent: false);
                return RedirectToAction("Index", "Home");
            }

            foreach (var item in result.Errors)
            {
                ModelState.AddModelError("", item.Description);
            }

            return View(model);
        }




        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Index", "Home");
            }

            var model = new LogInViewModel();

            return View(model);
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LogInViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await userManager.FindByNameAsync(model.UserName);

            if (user != null)
            {
                var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            ModelState.AddModelError("", "Invalid login");
            return View(model);
        }
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }



    }
}
