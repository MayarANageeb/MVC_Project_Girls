using Microsoft.AspNetCore.Mvc;
using MVCProject.Models;
using MVCProject.Repository;

namespace MVCProject.Controllers
{
    public class ProductController : Controller
    {
        IProductRepository productRepository;
       

        public ProductController(IProductRepository _productRepo) //injection
        {
            productRepository = _productRepo;
        }

        public IActionResult Index()
        {

            List<Product> prodModel = productRepository.GetAll();

            return View(prodModel);
        }
    }
}
