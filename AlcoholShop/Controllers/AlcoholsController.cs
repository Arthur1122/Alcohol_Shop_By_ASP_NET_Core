using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlcoholShop.Data;
using AlcoholShop.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlcoholShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlcoholsController : ControllerBase
    {
        private readonly AlcoholContext _context;
        private readonly IMapper _mapper;
        private readonly IAlcoholRepository _repository;

        public AlcoholsController(AlcoholContext context,IMapper mapper,IAlcoholRepository repository)
        {
            this._context = context;
            this._mapper = mapper;
            this._repository = repository;
        }
        // GET api/values
        [HttpGet]
        public async Task <ActionResult<AlcoholModel>> Get()
        {
            try
            {
                var result = _repository.Get_all_Alcohols();
                if (result == null) return BadRequest();
                return Ok(_mapper.Map<AlcoholModel[]>(result));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed database");
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] AlcoholModel model)
        {
            try
            {
                var result = _repository.Add(model);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed database");
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
