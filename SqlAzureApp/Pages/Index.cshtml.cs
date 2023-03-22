using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SqlAzureApp.Models;
using SqlAzureApp.Services;

namespace SqlAzureApp.Pages
{
    public class IndexModel : PageModel
    {
        //private readonly ILogger<IndexModel> _logger;

        //public IndexModel(ILogger<IndexModel> logger)
        //{
        //    _logger = logger;
        //}
        public List<Product> prodList = new List<Product>();

        public void OnGet()
        {
            ProductService prodService = new ProductService();
            prodList=prodService.GetProducts();
        }
    }
}