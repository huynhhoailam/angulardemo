using System.Collections.Generic;
using System.Linq;
using AngularDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace AngularDemo.Controllers {
    [Route ("api/[controller]")]
    public class CategoryController : Controller {
        private readonly ApplicationDBContext _context;
        public CategoryController (ApplicationDBContext context) {
            _context = context;
        }

        [HttpGet]
        [Route ("GetAllCategory")]
        public IEnumerable<Category> GetAll () {
            return _context.Categories.ToList ();
        }

        [HttpGet ("${id}")]
        [Route ("GetCategory")]
        public IActionResult GetById (int id) {
            var item = _context.Categories.FirstOrDefault (c => c.CategoryID == id);
            if (item == null) {
                return NotFound ();
            }
            return new ObjectResult (item);
        }

        [HttpPost]
        [Route ("AddCategory")]
        public IActionResult Create ([FromBody] Category item) {
            if (item == null) {
                return BadRequest ();
            }
            _context.Categories.Add (new Category {
                CategoryName = item.CategoryName,
                    Desctiption = item.Desctiption
            });
            _context.SaveChanges ();
            return Ok (new { message = "Category was added successfully." });
        }

        [HttpPut ("${id}")]
        [Route ("UpdateCategory")]
        public IActionResult Update (int id, [FromBody] Category item) {
            if (item == null) {
                return BadRequest ();
            }
            var category = _context.Categories.FirstOrDefault (c => c.CategoryID == id);
            if (category == null) {
                return NotFound ();
            }
            category.CategoryName = item.CategoryName;
            category.Desctiption = item.Desctiption;

            _context.Categories.Update(category);
            _context.SaveChanges();
            return Ok(new {message = "Category was updated successfully."});
        }

        [HttpDelete("${id}")]
        [Route("DeleteCategory")]
        public IActionResult Delete(int id)
        {
            var category = _context.Categories.FirstOrDefault(c => c.CategoryID == id);
            if(category == null)
            {
                return NotFound();
            }
            _context.Categories.Remove(category);
            _context.SaveChanges();
            return Ok(new {message = "Category was deleted successfully."});
        }

    }
}