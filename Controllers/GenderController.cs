using Microsoft.AspNetCore.Mvc;
using MoviesApi.Entities;
using MoviesApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApi.Controllers
{
    [Route("api/genders")]
    public class GenderController: ControllerBase
    {
        private readonly IRepository repository;

        public GenderController(IRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public ActionResult<List<Gender>> Get()
        {
            return repository.GetAllGenders();
        }

        [HttpGet("show/{Id:int}")]
        public ActionResult<Gender> Get(int Id)
        {
            var gender = repository.GetGenderById(Id);
            if(gender == null)
            {
                return NotFound();
            }
            return gender;
        }

        [HttpPost]
        public ActionResult Post()
        {
            return NoContent();
        }

        [HttpPut]
        public ActionResult Put()
        {
            return NoContent();
        }

        [HttpDelete]
        public ActionResult Delete()
        {
            return NoContent();
        }
    }
}
