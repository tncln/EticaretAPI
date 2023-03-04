
using EticaretAPI.Application.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EticaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IProductReadRepository _productReadRepository;
        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productReadRepository= productReadRepository;
            _productWriteRepository= productWriteRepository;
        }
        [HttpGet]
        public async void Get()
        {
            _productWriteRepository.AddRangeAsync(new()
            {
                new() { Id = Guid.NewGuid(), Name = "Product 1 ", Price =100, CreatedDate = DateTime.UtcNow, Stock=10 },
                new() { Id = Guid.NewGuid(), Name = "Product 2 ", Price =122, CreatedDate = DateTime.UtcNow, Stock=12 },
                new() { Id = Guid.NewGuid(), Name = "Product 3 ", Price =123, CreatedDate = DateTime.UtcNow, Stock=13 },
                new() { Id = Guid.NewGuid(), Name = "Product 4 ", Price =321, CreatedDate = DateTime.UtcNow, Stock=10 },
            });
            await _productWriteRepository.SaveAsync();
        }
    }
}
