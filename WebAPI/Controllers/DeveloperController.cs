using Domain;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
    public class DeveloperController : ControllerBase
    {
        private IUnitofWork _unitofWork;
        public DeveloperController(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
        }

        public IActionResult GetPopularDeveopers([FromQuery] int count)
        {
            var populardevelopers = _unitofWork.Developers.GetPopularDevelopers(count);
            return Ok(populardevelopers);
        }
        [HttpPost]
        public IActionResult AddDeveloperAndProject()
        {
            var developer = new Developer
            {
                Followers = 35,
                Name = "Mukesh Murugan"
            };
            var project = new Project
            {
                Name = "codewithmukesh"
            };
            _unitofWork.Developers.Add(developer);
            _unitofWork.Projects.Add(project);
            _unitofWork.Complete();
            return Ok();

        }
    }
}
