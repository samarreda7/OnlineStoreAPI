using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineStoreAPI.DTO;
using OnlineStoreAPI.Models;
using OnlineStoreAPI.Repository;
using System.Diagnostics.Eventing.Reader;

namespace OnlineStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        IproductRepository ProdRepo;
        public ProductController(IproductRepository _productRepository)
        {
            ProdRepo = _productRepository;
        }


        [HttpGet]
        [Route("AllProducts")]
        public IActionResult Products()
        {

            List<Product> prodList = ProdRepo.GetAll();
            if(prodList == null)
            {
                return BadRequest("Not Found");
            }
            return Ok(prodList);
        }

        [HttpGet]
        [Route("Id")]
        public IActionResult GetProduct(int Id)
        {

            Product productitem = ProdRepo.GetById(Id);
            if (productitem != null)
            {
                return Ok(productitem);
            }
            return BadRequest("NotFound Such an item with this Id");
        }


        [HttpPost]
        [Route("Add")]
        public IActionResult AddProduct([FromBody] NewProductDTO NewProduct)
        {
            if (NewProduct == null)
            {
                return BadRequest("Invalid Addition");
            }
            var newProduct = new Product
            {
                Name = NewProduct.Name,
                Description = NewProduct.Description,
                CategoryId = NewProduct.CategoryId,
                CreatedAt = DateTime.Now,
                stockQuantity = NewProduct.stockQuantity,
                Price = NewProduct.Price,
            };
            ProdRepo.AddProduct(newProduct);
            ProdRepo.Save();
            return Ok("Added Successfuly");
        }


        [HttpPut]
        public IActionResult UpdateProduct(int Id, [FromBody] UpdateProductDTO UpdateProduct)
        {
            //  Product exist = context.Products.FirstOrDefault(d => d.Id == Id);
            Product exist = ProdRepo.GetById(Id);
            if (UpdateProduct == null || exist == null)
            {
                return BadRequest("Not Found");
            }
            exist.Price = UpdateProduct.Price;
            exist.stockQuantity = UpdateProduct.stockQuantity;
            exist.CategoryId = UpdateProduct.CategoryId;
            ProdRepo.UpdateProduct(exist);
            ProdRepo.Save();
            //context.Update(exist);
            //context.SaveChanges();
            return Ok("Updated");
        }


        [HttpDelete]
        [Route("delete")]
        public IActionResult DeleteProduct(int Id)
        {
          Product prod = ProdRepo.GetById(Id);
            if (prod == null)
            {
                return BadRequest("Not Found");
            }
            ProdRepo.DeletePproduct(prod);
            ProdRepo.Save();
            return Ok("Deleted");
        }
    }
}    

