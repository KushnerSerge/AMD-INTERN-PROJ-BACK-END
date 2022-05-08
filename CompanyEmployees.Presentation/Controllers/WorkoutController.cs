using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyEmployees.Presentation.Controllers
{
    [Route("api/users/{userName}/workouts")]
    [ApiController]
    public class WorkoutController : ControllerBase
    {
        private readonly IServiceManager _service;
        private readonly UserManager<User> _userManager;
        private User? _user;
        private string userId;

        public WorkoutController(IServiceManager service, UserManager<User> userManager)
        {
            _service = service;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetWorkoutsForUser(string userName)
        {
            _user = await _userManager.FindByNameAsync(userName);
            userId = _user.Id;
            var workouts = await _service.WorkoutService.GetWorkoutsAsync(userId, trackChanges: false);

            return Ok(workouts);
        }

        [HttpGet("{id:guid}", Name = "GetWorkoutForUser")]
        public async Task<IActionResult> GetWorkoutForUser(string userName, Guid id)
        {
            _user = await _userManager.FindByNameAsync(userName);
            userId = _user.Id;
            var workout = await _service.WorkoutService.GetWorkoutAsync(userId, id, trackChanges: false);
            return Ok(workout);
        }


        [HttpPost]
        public async Task<IActionResult> CreateWorkout(string username, [FromBody] WorkoutForCreationDto workout)
        {
            _user = await _userManager.FindByNameAsync(username);
            userId = _user.Id;
            if (workout is null)
                return BadRequest("WorkoutForCreationDto object is null");

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            var createdWorkout = await _service.WorkoutService.CreateWorkoutForUserAsync(userId, workout, trackChanges: false);

            return CreatedAtRoute("GetWorkoutForUser", new { username, id = createdWorkout.WorkoutId }, createdWorkout);
            //  return Ok();

        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> UpdateWorkout(string username, Guid id, [FromBody] WorkoutForUpdateDto workout)
        {
            _user = await _userManager.FindByNameAsync(username);
            userId = _user.Id;
            if (workout is null)
                return BadRequest("WorkoutForUpdateDto object is null");

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            await _service.WorkoutService.UpdateWorkoutForUserAsync(userId, id, workout, trackChanges: true);

            return NoContent();
        }


        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteWorkoutForUser(string username, Guid id)
        {
            _user = await _userManager.FindByNameAsync(username);
            userId = _user.Id;
            await _service.WorkoutService.DeleteWorkoutForUser(userId, id, trackChanges: false);

            return NoContent();
        }


    }
}
