namespace F.Controllers
{
    using Freight.Models;
    using Freight.Services;
    using Microsoft.AspNetCore.Mvc;
    using System;

    [Route("[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private ICompanyService _companyService;
        public CompanyController(ICompanyService companyService) {
            _companyService = companyService;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_companyService.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult Get(long id)
        {
            return Ok(_companyService.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Company value)
        {
            _companyService.Save(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(long id, [FromBody] Company value)
        {
            value.Id = id;
            _companyService.Save(value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
