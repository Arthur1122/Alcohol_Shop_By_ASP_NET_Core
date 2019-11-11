using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Cors;
using AlcoholShop.Data;
using AlcoholShop.Data.Entites;
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
        public ActionResult<AlcoholModel> Get(int id)
        {
            try
            {
                var result = _repository.Get_Alcohol_byId(id);
                if (result == null) return BadRequest();
                return Ok(_mapper.Map<AlcoholModel>(result));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed database");
            }
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post(AlcoholModel model)
        {
            try
            {
                Alcohol result = _repository.Add(model);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed database");
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put(AlcoholModel model)
        {
            try
            {
                var alcohol = _repository.Get_Alcohol_byId(model.Model_Id);
                if (alcohol == null) return NotFound();

                _mapper.Map(model, alcohol);
                _repository.SaveChanges();
                return Ok(alcohol);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed database");
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var alcohol = _repository.Get_Alcohol_byId(id);
                if (alcohol == null) return NotFound();

                _repository.Delete(alcohol);
                _repository.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed database");
            }
        }
    }
}
