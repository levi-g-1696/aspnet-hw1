using aspnetHW1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq;

namespace aspnetHW1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        public List<Animal> GetAnimals()
        {
            return new List<Animal>
            {
                new Animal(10, "Cat", 2),
                new Animal(11, "Jirafa", 1),
                new Animal(12, "Dog", 3),
                new Animal(13, "Cow", 5),
                new Animal(14, "Rabbit", 2)
            };
        }
        [Route("Smile")]
        public IActionResult ReturnSmile()
        {
            return Ok(":)");
        }
        [Route("/special/{name2}")]
        public ActionResult<Animal> GetAnimalByName2(string name2)
        {
            string smileLink = "https://localhost:44337/api/animals/special/Smile";
            var animalList = GetAnimals();
            var animal = (from a in animalList where a.Name == name2 select a).First();
            if (animal == null) return NotFound();
            else if (animal.Name == "Jirafa") return Redirect(smileLink);

            else return animal;

        }


       // [Route("{name}")]
        //public IActionResult GetAnimalByName(string name)
        //{


        //    string smileLink = "https://localhost:44337/api/animals/Smile";
        //    var animalList = GetAnimals();
        //    var animal = (from a in animalList where a.Name == name select a).First();
        //    if (animal == null) return NotFound();
        //    else if (animal.Name == "Jirafa") return Redirect(smileLink);

        //    else return Ok(animal.Name + "  age:" + animal.Age);
        //}


    }



}


