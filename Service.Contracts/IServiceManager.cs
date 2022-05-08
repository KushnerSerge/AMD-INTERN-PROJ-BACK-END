namespace Service.Contracts;

public interface IServiceManager
{
	ICompanyService CompanyService { get; }
	IEmployeeService EmployeeService { get; }
	IMealService MealService { get; }
	IWorkoutService WorkoutService { get; }	
	IIngredientService IngredientService { get; }	
	IAuthenticationService AuthenticationService { get; }
}
