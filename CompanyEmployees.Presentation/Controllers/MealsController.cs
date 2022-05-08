using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects;


namespace CompanyEmployees.Presentation.Controllers
{
    [Route("api/users/{userName}/meals")]
    [ApiController]
    public class MealsController : ControllerBase
    {
        private readonly IServiceManager _service;
        private readonly UserManager<User> _userManager;
        private User? _user;
        private string userId;
        public MealsController(IServiceManager service, UserManager<User> userManager)
        {
            _service = service;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetMealsForUser(string userName)
        {
            _user = await _userManager.FindByNameAsync(userName);
            userId = _user.Id;
            var meals = await _service.MealService.GetMealsAsync(userId, trackChanges: false);

            return Ok(meals);
        }

        [HttpGet("{id:guid}", Name = "GetMealForUser")]
        public async Task<IActionResult> GetMealForUser(string userName, Guid id)
        {
            _user = await _userManager.FindByNameAsync(userName);
            userId = _user.Id;
            var meal = await _service.MealService.GetMealAndIngredientsAsync(userId, id, trackChanges: false);
            return Ok(meal);
        }

        // find why is not founded
        [HttpGet("element/{id:guid}")]
        public async Task<IActionResult> GetMealAndIngredientsForUser(string userName, Guid id)
        {
            _user = await _userManager.FindByNameAsync(userName);
            userId = _user.Id;
            var meal = await _service.MealService.GetMealAsync(userId, id, trackChanges: false);
            return Ok(meal);
        }


        [HttpPost]
        public async Task<IActionResult> CreateMeal(string username, [FromBody] MealForCreationDto meal)
        {
            _user = await _userManager.FindByNameAsync(username);
            // Console.WriteLine("userul este" + _user.Id);
            userId = _user.Id;
            if (meal is null)
                return BadRequest("MealForCreationDto object is null");

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            var createdMeal = await _service.MealService.CreateMealForUserAsync(userId, meal, trackChanges: false);

            return CreatedAtRoute("GetMealForUser", new { username, id = createdMeal.MealId }, createdMeal);
            //  return Ok();

        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> UpdateMeal(string username,Guid id ,[FromBody] MealForUpdateDto meal)
        {
            _user = await _userManager.FindByNameAsync(username);
            // Console.WriteLine("userul este" + _user.Id);
            userId = _user.Id;
            if (meal is null)
                return BadRequest("MealForUpdateDto object is null");

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            await _service.MealService.UpdateMealForUserAsync(userId,id, meal, trackChanges: true);

            return NoContent();
        }


        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteMealForUser(string username, Guid id)
        {
            _user = await _userManager.FindByNameAsync(username);
            userId = _user.Id;
            await _service.MealService.DeleteMealForUser(userId, id, trackChanges: false);

            return NoContent();
        }


    }
}
