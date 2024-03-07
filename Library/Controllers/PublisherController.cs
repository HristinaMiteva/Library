using Library.Contracts;
using Library.Models.PublisherViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
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

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddPublisherViewModel viewModel)
        {
            if (!ModelState.IsValid) { return View(viewModel); }
            await this.publisherServices.AddPublisherAsync(viewModel);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            await publisherServices.DeletePublisherAsync(id);
            return RedirectToAction("Index", "Home");
        }

    }
}
