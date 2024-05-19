using Microsoft.AspNetCore.Mvc;
using WebApiDemo.Models;
using WebApiDemo.Requests;

namespace WebApiDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShirtsController: ControllerBase

    {

        private List<Shirt> shirts = new List<Shirt>() {

            new Shirt {ShirtId = 1, Brand = "My Brand", Color = "Blue", Gender = "Men", Price = 20, Size = 3 },
            new Shirt {ShirtId = 3, Brand = "My Brand", Color = "Red", Gender = "Men", Price = 33, Size = 9 },
            new Shirt {ShirtId = 4, Brand = "His brand", Color = "grey", Gender = "Women", Price = 440, Size = 7 }
        };
        [HttpGet]
        public string GetShirts() //this is an action method
        {
            return "Reading all teh shirts";
        }

        [HttpGet("{id}")]
        public IActionResult GetShirts(int id) //if the method returns different types of data, use the IActionResult as a return type
        {
            var shirt = shirts.First(x => x.ShirtId == id);


            if (shirt == null)
            {
                return NotFound();
            }
            return Ok(shirt);
        }

        [HttpPost]
        public string PostShirts([FromBody] Shirt request)
        {
            return $"Creating a shirt with brand {request.Brand} and size {request.Size}. It is also {request.Gender}";
        }

        [HttpPut("/{id}")]
        public string PutShirts(int id)
        {
            return $"Updating a shirt of id: {id}";
        }

        [HttpDelete("/{id}")]
        public string DeleteShirts(int id)
        {
            return $"Delete a shirt of id: {id}";
        }
    }
}
