using System;
using DNTCaptcha.Core;
using Humanizer.DateTimeHumanizeStrategy;
using Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.Extensions.Options;
using Models;

namespace Controllers
{

    public class LoginController : Controller
    {
        private readonly IDNTCaptchaValidatorService _validatorservice;
        private readonly DNTCaptchaOptions _captchaOptions;
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;
        public LoginController(IDNTCaptchaValidatorService dNTCaptchaValidatorService, IOptions<DNTCaptchaOptions> options, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
            this._captchaOptions = options == null ? throw new ArgumentNullException(nameof(options)) : options.Value;
            this._validatorservice = dNTCaptchaValidatorService;
        }
        public IActionResult In()
        {
            return View();
        }

        public IActionResult Up()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            try
            {
                await _signInManager.SignOutAsync();
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                // Hata mesajını loglama veya hata sayfasına yönlendirme gibi işlemler burada yapılabilir.
                return RedirectToAction("Error", "Home");
            }

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> In(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                if (_validatorservice.HasRequestValidCaptchaEntry())
                {
                    var user = await _userManager.FindByEmailAsync(model.Email);
                    if (user == null)
                    {
                        ModelState.AddModelError("", "Bu kullanıcı bulunamadı");
                        return View(model);
                    }
                    var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    ModelState.AddModelError("", "Şifreyi Yanlış Girdiniz");
                    return View(model);
                }
                this.ModelState.AddModelError(_captchaOptions.CaptchaComponent.CaptchaInputName, "Please Enter Valid Captcha");

                return View(model);

            }

        }
        [HttpPost]

        public async Task<IActionResult> Up(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            User user = new User()
            {
                Email = model.Email,
                UserName = model.UserName,
                FirstName = model.FirstName,
                LastName = model.LastName,

            };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("In", "Login");
            }
            else
            {

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(model);
            }


        }



    }
}