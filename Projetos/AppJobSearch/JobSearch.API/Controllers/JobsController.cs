using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobSearch.API.DataBase;
using JobSearch.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobSearch.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private readonly int numberOfRegistryByPage = 5;

        private readonly JobSearchContext _data;

        public JobsController(JobSearchContext data)
        {
            _data = data;
        }

        [HttpGet]
        public IEnumerable<Job> GetJobs(string word, string cityState, int numberOfPage = 1)
        {
            if (word == null)
                word = "";

            if (cityState == null)
                cityState = "";

            return _data.Jobs.Where(j => 
                j.CityState.ToLower().Contains(cityState.ToLower()) &&
                (
                    j.JobTitle.ToLower().Contains(word.ToLower()) ||
                    j.TecnologyTools.ToLower().Contains(word.ToLower()) ||
                    j.Company.ToLower().Contains(word.ToLower())
                ) &&
                j.PublicationDate > DateTime.Now.AddDays(-30)
            ).Skip(numberOfRegistryByPage * (numberOfPage - 1))    //Indica quantos registro irá pular
             .Take(numberOfRegistryByPage)    //Indica quantos registros irá retornar
             .ToList();
        }

        [HttpGet("{id}")]
        public IActionResult GetJob(int id)
        {
            Job jobDb = _data.Jobs.Find(id);

            if (jobDb == null)
                return NotFound();

            return new JsonResult(jobDb);
        }

        [HttpPost]
        public IActionResult AddJob(Job job)
        {
            //TODO - Validação...

            job.PublicationDate = DateTime.Now;

            _data.Jobs.Add(job);
            _data.SaveChanges();

            return CreatedAtAction("GetJob", new { id = job.Id }, job);
        }
    }
}
