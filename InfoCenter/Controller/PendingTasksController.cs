using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;
using WorkingData.Repository.DivisionsBus;

namespace InfoCenter.Controller
{
    [Route("PendingTasksController")]
    [ApiController]

    public class PendingTasksController(IDivisionRep divisionRep) : ControllerBase
    {


        [Route("{id}")]
        [HttpGet]
        public IActionResult GetPendingTasksDivisionId(long id)

        {

            var pt = divisionRep.GetbyIdDivisionPendingTasks(id);

            return new JsonResult(pt);
        }

    }
}
