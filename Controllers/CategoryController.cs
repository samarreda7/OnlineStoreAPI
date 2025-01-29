using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Abstractions;
using OnlineStoreAPI.DTO;
using OnlineStoreAPI.Models;
using OnlineStoreAPI.Repository;

namespace OnlineStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
       IcategoryRepository catgRepo;
        public CategoryController(IcategoryRepository _catgRepo) 
        {
            this.catgRepo = _catgRepo;
        }
        [HttpGet]
        [Route("All")]
        public IActionResult GetAll() 
        {
            List<Category> CatgList = catgRepo.GetAll(); 
            if (CatgList == null) 
            {
                return BadRequest("No Categories To Show");
            }
            return Ok(CatgList);
        }
        [HttpGet]
        [Route("Id")]
        public IActionResult GetById(int id)
        {
           Category catg = catgRepo.GetById(id);
            if (catg == null) 
            {
            return BadRequest("Not Found");
            }
            return Ok(catg);
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult AddCategory(CategoryDTO Newcatg)
        {
            if (Newcatg == null)
            {
                return BadRequest("Invalid Addition");
            }
            Category NewCatg = new Category
            {
                Name = Newcatg.Name,
                Description = Newcatg.Description,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };
            catgRepo.AddCategory(NewCatg);
            catgRepo.Save();
            return Ok("Added Successfuly");
        }
        [HttpDelete]
        [Route("Remove")]
        public IActionResult DeleteById(int id) 
        {
            Category catg = catgRepo.GetById(id);
            if(catg == null)
            {
             return BadRequest("Not Exist !");
            }
            catgRepo.DeleteCategory(catg);
            catgRepo.Save();
            return Ok("Deleted Successfuly");
            }

        [HttpPut]
        [Route("Update")]
        public IActionResult UpdateCategory(int Id, [FromBody] CategoryDTO updatecatg)
        {
            Category exist = catgRepo.GetById(Id);
            if (updatecatg == null || exist == null)
            {
                return BadRequest("Faile to Update");
            }
            if (updatecatg.Name != null && updatecatg.Name != "string") 
            { 
            exist.Name = updatecatg.Name;
            }
            else
            {
                exist.Name = exist.Name;
            }
            if(updatecatg.Description != null && updatecatg.Description != "string")
            {
                exist.Description = updatecatg.Description;
            }
            {
                exist.Description = exist.Description;
            }
            exist.UpdatedAt = DateTime.Now;
            exist.CreatedAt = exist.CreatedAt;
            catgRepo.UpdateCategory(exist);
            catgRepo.Save();
            return Ok("Updated successfully");
        }
    }
}
