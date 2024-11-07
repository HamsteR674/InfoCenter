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

            var pendingTasks = pending.GetbyIdDivisionPendingTasks(id);
            var takenTasks1 = takenTasks.GetbyIdDivision(id);
          Tasks tasks = new Tasks(pendingTasks, takenTasks1) ;
         
            return new JsonResult(tasks);
        }
        [Route("cust/{id}")]
        [HttpGet]
        public JsonResult GetCustomId(int id)

        {

            var pendingTasks = pending.GetbyCustomStandTasks(id);
            var takenTasks1 = takenTasks.GetbyIdCustomStand(id);
            Tasks tasks = new Tasks(pendingTasks, takenTasks1);

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
