namespace Contracts;

public interface IRepositoryManager
{
	ICompanyRepository Company { get; }
	IEmployeeRepository Employee { get; }
	IMealRepository Meal { get; }
	IIngredientRepository Ingredient { get; }
	IWorkoutRepository Workout { get; }	
	Task SaveAsync();
}
