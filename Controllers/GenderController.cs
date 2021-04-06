using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using MoviesApi.Entities;
using MoviesApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApi.Controllers
{
    [Route("api/genders")]
    [ApiController]
    public class GenderController: ControllerBase
    {
        private readonly IRepository repository;

        public GenderController(IRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Gender>>> Get()
        {
            return await repository.GetAllGenders();
        }

        [HttpGet("show/{Id:int}")]
        public ActionResult<Gender> Get(int Id, [BindRequired] string param2)
        {

            var gender = repository.GetGenderById(Id);
            if(gender == null)
            {
                return NotFound();
            }
            return gender;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Gender gender)
        {
            repository.AddGender(gender);
            return NoContent();
        }

        [HttpPut]
        public ActionResult Put([FromBody] Gender gender)
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
