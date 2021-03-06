using AcademyG.Week8.Core.Interfaces;
using AcademyG.Week8.Core.Models;
using AcademyG.Week8.MVC.Helpers;
using AcademyG.Week8.MVC.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AcademyG.Week8.MVC.Controllers
{
    [AllowAnonymous]
    public class UserController : Controller
    {
        private readonly IMainBusinessLayer bl;

        public UserController(IMainBusinessLayer mainBL)
        {
            bl = mainBL;
        }

        public IActionResult Login(string returnURL)
        {
            return View(new UserLoginViewModel { ReturnUrl = returnURL });
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginViewModel uvm)
        {
            if(uvm == null)
            {
                return View("ExceptionError", new ResultBL(false,"Invalid User"));
            }

            var user = bl.GetUserByEmail(uvm.Email);
            if(user != null && ModelState.IsValid)
            {
                //Verifica Password
                if (user.Password.Equals(uvm.Password))
                {
                    //UTENTE AUTENTICATO
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Email, user.Email),
                        new Claim(ClaimTypes.Role, user.Role.ToString())
                    };

                    var authProperties = new AuthenticationProperties
                    {
                        ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(30),
                        RedirectUri = uvm.ReturnUrl
                    };

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentity),
                        authProperties
                    );
                    return Redirect("/");
                }
                else
                {
                    ModelState.AddModelError(nameof(uvm.Password), "Incorrect Password");
                    return View(uvm);
                }
            }
            else
            {
                ModelState.AddModelError(nameof(uvm.Email), "Invalid Email");
                return View(uvm);
            }

            return View(uvm);
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }

        public IActionResult Forbidden()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View(new UserRegistrationViewModel());
        }

        [HttpPost]
        public IActionResult Register(UserRegistrationViewModel urvm)
        {
            if (!ModelState.IsValid)
            {
                return View(urvm);
            }

            //mapping da UserRegistrationViewModel -> User
            var user = urvm.ToUser();
            //Aggiunta a db del nuovo utente
            var result = bl.AddNewUser(user);
            if (result.Success)
                return Redirect("/");
            return View("ExceptionError", result);
        }
    }
}
