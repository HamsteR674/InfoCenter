using InteractionDb.Repository.TakenTasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;
using WorkingData.Repository.PendingRepBus;
using WorkingData.EntityModel.PendingTasks;
using WorkingData.EntityModel.Tasks;

namespace InfoCenter.Controllers
{
    [Route("api/tasks")]
    [ApiController]

    public class TasksController(IPendingRepBus pending,ITakenTasks takenTasks) : ControllerBase
    {


        [Route("{id}")]
        [HttpGet]
        public JsonResult GetTasksDivisionId(long id)

        {

            var pt = pending.GetbyIdDivisionPendingTasks(id);
            var tt = takenTasks.GetbyIdDivision(id);
          Tasks tasks = new Tasks(pt,tt ) ;
         
            return new JsonResult(tasks);
        }
        [Route("cust/{id}")]
        [HttpGet]
        public JsonResult GetCustomId(int id)

        {

            var pt = pending.GetbyCustomStandTasks(id);
            var tt = takenTasks.GetbyIdCustomStand(id);
            Tasks tasks = new Tasks(pt, tt);

            return new JsonResult(tasks);
        }

        [Route("cust/update")]
        [HttpPatch]

        public JsonResult GetUpdateTasks(NewTasks newtasks)

        {
          
         
            pending.Update(newtasks);

            return new JsonResult("Update");
        }
    }
}
