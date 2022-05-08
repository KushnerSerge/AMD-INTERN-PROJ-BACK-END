using Contracts;

namespace Repository;

public sealed class RepositoryManager : IRepositoryManager
{
	private readonly RepositoryContext _repositoryContext;
	private readonly Lazy<ICompanyRepository> _companyRepository;
	private readonly Lazy<IEmployeeRepository> _employeeRepository;
	private readonly Lazy<IMealRepository> _mealRepository;
	private readonly Lazy<IIngredientRepository> _ingredientRepository;
	private readonly Lazy<IWorkoutRepository> _workoutRepository;

	public RepositoryManager(RepositoryContext repositoryContext)
	{
		_repositoryContext = repositoryContext;
		_companyRepository = new Lazy<ICompanyRepository>(() => new CompanyRepository(repositoryContext));
		_employeeRepository = new Lazy<IEmployeeRepository>(() => new EmployeeRepository(repositoryContext));
		_mealRepository = new Lazy<IMealRepository>(() => new MealRepository(repositoryContext));
		_ingredientRepository = new Lazy<IIngredientRepository>(() => new IngredientRepository(repositoryContext));
		_workoutRepository = new Lazy<IWorkoutRepository>(() => new WorkoutRepository(repositoryContext));
	}

	public ICompanyRepository Company => _companyRepository.Value;
	public IEmployeeRepository Employee => _employeeRepository.Value;

	public IMealRepository Meal => _mealRepository.Value;
	public IIngredientRepository Ingredient => _ingredientRepository.Value;
	public IWorkoutRepository Workout => _workoutRepository.Value;

	public async Task SaveAsync() => await _repositoryContext.SaveChangesAsync();
}
