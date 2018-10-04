using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestMakerApp.ViewModels;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestMakerApp.Controllers
{
    [Route("api/[controller]")]
    public class ResultController : Controller
    {
        // GET: api/question/all
        [HttpGet("All/{quizId}")]
        public IActionResult All(int quizId)
        {
            var sampleResults = new List<ResultViewModel>();

            //add a first sample result

            sampleResults.Add(new ResultViewModel()
            {
                Id = 1,
                QuizId = quizId,
                Text = "What do you value most in your life?",
                CreatedDate = DateTime.Now,
                LastModifiedDate = DateTime.Now
            });

            // add a bunch of other sample results

            for (int i = 2; i < 5; i++)
            {
                sampleResults.Add(new ResultViewModel()
                {
                    Id = 1,
                    QuizId = quizId,
                    Text = String.Format("SampleQuestion{0}", i),
                    CreatedDate = DateTime.Now,
                    LastModifiedDate = DateTime.Now
                });
            }

            //output results in JSON format

            return new JsonResult(
                sampleResults,
                new JsonSerializerSettings()
                {
                    Formatting = Formatting.Indented
                });
        }
    }
        
}
