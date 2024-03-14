using Library.Contracts;
using Library.Models.PublisherViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    [Authorize]
    public class PublisherController : Controller
    {
        private readonly IPublisherServices publisherServices;

        public PublisherController(IPublisherServices publisherServices)
        {
            this.publisherServices = publisherServices;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var model = await publisherServices.GetAllAsync();
            return View(model);
        }
        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> Add(AddPublisherViewModel viewModel)
        {
            if (!ModelState.IsValid) { return View(viewModel); }
            await this.publisherServices.AddPublisherAsync(viewModel);
            return RedirectToAction("Index", "Home");
        }
        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            await publisherServices.DeletePublisherAsync(id);
            return RedirectToAction("Index", "Home");
        }

    }
}
