using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Yazlab2Proje3.Identity;
using Yazlab2Proje3.Models;
using Neo4jClient;
using Newtonsoft.Json;
using System.Net;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Yazlab2Proje3.Controllers
{
    public class AccountController:Controller
    {
        private readonly IGraphClient _client;
        private readonly IWebHostEnvironment _hostingEnvironment;
    
        private UserManager<Users> _userManager;
        private SignInManager<Users> _signInManager;
        
        public AccountController(UserManager<Users> userManager, SignInManager<Users> signInManager, IWebHostEnvironment hostingEnvironment, IGraphClient client)
        {
            _userManager = userManager;
            _signInManager = signInManager;  
            _hostingEnvironment = hostingEnvironment;
            _client = client;
            
        }
        public IActionResult Login()
        {   

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {   
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.FindByNameAsync(model.UserName);
            if(user == null)
            {
                ModelState.AddModelError("UserName", "Bu kullanıcı adıyla eşleşen bir kayıt yok");
                
                return View(model);
            }
            if(model.Password == null)
            {
                ModelState.AddModelError("Password", "Boş bırakılamaz");
            }
            var result = await _signInManager.PasswordSignInAsync(user,model.Password,false,false);
            if(result.Succeeded)
            {
                return RedirectToAction("swagger","Login");
            }
            ModelState.AddModelError("", "Girilen kullanıcı adı veya parola yanlış.");
            return View(model);
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }
            var user = new Users(){
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.UserName,
                Email = model.Email

            };
            var result = await _userManager.CreateAsync(user, model.Password);
            if(result.Succeeded)
            {
                return RedirectToAction("Login","Account");
            }

            ModelState.AddModelError("Password","En az bir büyük, bir küçük harf ve rakamlardan oluşmalıdır. En az 5 karakter içermelidir");
            
            return View(model);
        }  
        

        
    }
}