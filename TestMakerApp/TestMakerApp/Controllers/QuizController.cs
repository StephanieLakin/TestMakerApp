using System;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TestMakerApp.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace TestMakerApp.Controllers

{
    [Route("api/controller")]
    public class QuizController : Controller
    {
        #region Restful conventions methods
        /// <summary>
        /// GET api/quiz/{id}
        /// Retrieves the quiz with the given {id}
        /// </summary>
        /// <param name="id">the ID of an existing quiz</param>
        /// <returns>the quiz with the given {id}</returns>

        [HttpGet("{id}")]
        public IActionResult GET(int id)
        {
            // create a sample quiz to match the given request
            var v = new QuizViewModel()
            {
                Id = id,
                Title = String.Format("Sample quiz qith id {0}", id),
                Description = "Not a real quiz: it's just a sample!",
                CreatedDate = DateTime.Now,
                LastModifiedDate = DateTime.Now
            };
            // output the result in JSON format
            return new JsonResult(
            v,
           new JsonSerializerSettings()
           {
               Formatting = Formatting.Indented
           });

        }
        ///<summary>
        ///Adds a new quiz to the database
        ///</summary>
        ///<param name="model">The QuizViewModel containingthe data to insert</param>
        ///

        [HttpPut]
        public IActionResult Put(QuizViewModel model)
        {
            throw new NotImplementedException();
        }
        ///<summary>
        ///Edit the quiz with the given {id}
        ///</summary>
        ///<param name="model">The QuizViewModel containingthe data to update</param>
        [HttpPost]
        public IActionResult Post(QuizViewModel model)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Deletes the quiz with the given id from the database
        /// </summary>
        /// <param name="id">The id of an existing test</param>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region Attrivute-based routing methods
    ///<summary>
    ///GET: api/quiz/latest
    ///Retrieves the {Num> latest quizzes
    ///</summary>

}