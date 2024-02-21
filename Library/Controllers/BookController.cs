﻿using Library.Contracts;
using Library.Data.Models;
using Library.Models.BookViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    [Authorize]
    public class BookController : Controller
    {
        private readonly UserManager<User> userManager;

        private readonly IBookServices bookServices;

        public BookController(IBookServices bookServices, UserManager<User> userManager)
        {
            this.bookServices = bookServices;
            this.userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await bookServices.GetAllAsync();
            return View(model);
        }

        [HttpGet]
        [Authorize(Roles = "Writer, Redactor, Administrator")]
        public IActionResult Add()
        {
            ViewBag.PublisherId = this.bookServices.AddBookAsync();
            return View();
        }


        [HttpPost]
        [Authorize(Roles = "Writer, Redactor, Administrator")]
        public async Task<IActionResult> Add(AddBookViewModel viewModel)
        {
            if (!ModelState.IsValid) { return View(viewModel); }
            await this.bookServices.AddBookAsync(viewModel);
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        [Authorize(Roles = "Writer, Administrator, Reader")]
        public async Task<IActionResult> ReadBook(Guid id)
        {
            var user = await userManager.FindByNameAsync(User.Identity?.Name);
            await this.bookServices.ReadBookAsync(id, user);

            return RedirectToAction("Index", "Home");

        }
        [HttpGet]
        [Authorize(Roles = "Writer, Administrator, Reader")]
        public async Task<IActionResult> BookRead()
        {
            var user = await userManager.GetUserAsync(User);
            try
            {
                return View(await bookServices.BookReadAsync(user));

            }
            catch (Exception ex) { ModelState.AddModelError("", ex.Message); }


            return RedirectToAction("Index", "Home");


        }
    }
}
