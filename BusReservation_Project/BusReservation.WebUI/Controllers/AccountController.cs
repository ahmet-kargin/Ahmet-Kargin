using BusReservation.Core;
using BusReservation.WebUI.EmailServices;
using BusReservation.WebUI.Identity;
using BusReservation.WebUI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusReservation.WebUI.Controllers
{
    public class AccountController:Controller
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;
        private IEmailSender _emailSender;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            this._emailSender = emailSender;
        }
        public IActionResult AccessDenied()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
       
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = new User() { 
                FirstName=model.FirstName,
                LastName=model.LastName,
                UserName=model.UserName,
                Email=model.Email
            };

            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var url = Url.Action("ConfirmEmail", "Account", new
                {
                    userId=user.Id,
                    token=code
                });
                await _emailSender.SendEmailAsync(model.Email, "Confirm Account!", $"Please click <a href = 'https://localhost:5001{url}' > click to confirm your email address! </ a >");
                TempData["Message"] = JobManager.CreateMessage("", "Click on the confirmation link sent to your e-mail to complete your registration!", "warning");
                return RedirectToAction("Login", "Account");
            }
            return View();
        }
        public IActionResult Login(string returnUrl)
        {
            var login = new LoginModel()
            {
                ReturnUrl = returnUrl
            };
            return View(login);

        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByNameAsync(model.UserName);
            if (user==null)
            {
                ModelState.AddModelError("", "There is no such as User");
                return View(model);

            }
            if (!await _userManager.IsEmailConfirmedAsync(user))
            {
                ModelState.AddModelError("", "You have not approved the confirmation link sent to your confirmation address!");
                return View(model);
            }
            var result = await _signInManager.PasswordSignInAsync(user, model.Password, true, true);
            if (result.Succeeded)
            {
                return Redirect(model.ReturnUrl ?? "~/");
            }
            TempData["Message"] = JobManager.CreateMessage("DİKKAT", "Şifreniz hatalı!", "danger");
            return View(model);
        } 
        public IActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string email)
        {
            if (String.IsNullOrEmpty(email))
            {
                TempData["Message"] = JobManager.CreateMessage("WARNING", "Please enter your password", "danger");
                return View();
            }
            var user = await _userManager.FindByEmailAsync(email);
            if (user==null)
            {
                TempData["Message"] = JobManager.CreateMessage("WARNING", "There is no such as Email account", "danger");
                return View();
            }
            var code = await _userManager.GeneratePasswordResetTokenAsync(user);
            var url = Url.Action("ResetPassword", "Account", new
            {
                userId=user.Id,
                token=code
            });
            await _emailSender.SendEmailAsync(
               email,
               "BusReservation Password Reset",
               $"Please click <a href='https://localhost:5001{url}'>to convert your password.</a>"
               );
            TempData["Message"] = JobManager.CreateMessage("", "Password reset link has been sent to your registered e-mail address. Please check.", "warning");
            return RedirectToAction("Login");
        }

        public IActionResult ResetPassword(string userId, string token)
        {
            if (userId == null || token == null)
            {
                TempData["Message"] = JobManager.CreateMessage("", "There was a problem. Try again later!", "danger");
                return RedirectToAction("Index", "Home");
            }
            var model = new ResetPasswordModel()
            {
                Token = token
            };
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                TempData["Message"] = JobManager.CreateMessage("", "There was a problem, please check the information and try again!", "danger");
                return View();
            }
            var result = await _userManager.ResetPasswordAsync(
                user, model.Token, model.Password
                );
            if (result.Succeeded)
            {
                return RedirectToAction("Login");
            }

            TempData["Message"] = JobManager.CreateMessage("", "There was a problem, please contact the admin.", "danger");
            return Redirect("~/");

        }
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId == null || token == null)
            {
                TempData["Message"] = JobManager.CreateMessage("", "Bir sorun oluştur", "warning");
                return View();
            }

            var user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, token);
                if (result.Succeeded)
                {
                    TempData["Message"] = JobManager.CreateMessage("", "Approved your account!", "success");
                }
                return View();
            }

            TempData["Message"] = JobManager.CreateMessage("", "Your account could not be verified! Please try again later", "danger");
            return View();
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Redirect("~/");
        }
    }
}
