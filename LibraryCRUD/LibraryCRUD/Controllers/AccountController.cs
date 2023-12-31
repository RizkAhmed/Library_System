﻿using CoreIdentity.ViewModels;
using LibraryCRUD.Models;
using LibraryCRUD.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryCRUD.Controllers
{
   
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(AppDbContext context,UserManager<IdentityUser> userManager,SignInManager<IdentityUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegistrationViewModel model)
        {
            if (ModelState.IsValid)
            {
                UserAccount UserID ;
                if (model.Id < 1)
                {
                     UserID = new UserAccount();
                    _context.userAccounts.Add(UserID);
                    _context.SaveChanges();
                    model.Id = UserID.Id;
                }

                UserID = await _context.userAccounts.FindAsync(model.Id);
                
                var user = new IdentityUser()
                {
                    Id = UserID.Id.ToString(),
                    Email = model.Email,
                    UserName = model.UserName,
                };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, true);
                    return RedirectToAction(nameof(Index), "Book");
                }
                else
                {
                    foreach (var erorr in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, erorr.Description);
                    }
                }
            }
            return View(model);
        }

        public IActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user != null)
                {
                    var result =
                        await _signInManager.PasswordSignInAsync(user, model.Password,true, false);
                    if (result.Succeeded) 
                    { 
                        return RedirectToAction("Index", "Book"); 
                    }
                    else ModelState.AddModelError("", "Incorrect Email Or PassWord");
                }
                else 
                { 
                    ModelState.AddModelError("", "Invalid Email or PassWord"); 
                }
            }
            return View(model);
        }
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }
        [Authorize]
        public async Task<IActionResult> FavoritBooks()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var userBooks = await _context.userAccounts.Include(b => b.FavoritBooks).ThenInclude(a => a.Author).SingleOrDefaultAsync(u => u.Id == Convert.ToInt32(user.Id));
            ViewBag.userId = userBooks.Id;
            ViewBag.IsAll = false;
            return View("~/Views/Book/Index.cshtml", userBooks.FavoritBooks);

        }
        public async Task<IActionResult>AddToFavorit(int?id)
        {

            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var userBooks = await _context.userAccounts.Include(b => b.FavoritBooks).ThenInclude(a => a.Author).SingleOrDefaultAsync(u => u.Id == Convert.ToInt32(user.Id));
            if (id == null)
                return BadRequest();
            var book = await _context.books.FindAsync(id);
            if (book == null)
                return NotFound();

            userBooks.FavoritBooks.Add(book);
            _context.SaveChanges();
            return Ok();
        }
        public async Task<IActionResult> DeleteFromFavorit(int? id)
        {


            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var userBooks = await _context.userAccounts.Include(b => b.FavoritBooks).ThenInclude(a => a.Author).SingleOrDefaultAsync(u => u.Id == Convert.ToInt32(user.Id));
            if (id == null)
                return BadRequest();
            var book = await _context.books.FindAsync(id);
            if (book == null)
                return NotFound();

            userBooks.FavoritBooks.Remove(book);
            _context.SaveChanges();
            return Ok();
        }
    }
}
