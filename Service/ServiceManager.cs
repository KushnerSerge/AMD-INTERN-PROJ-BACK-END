﻿using AutoMapper;
using Microsoft.Extensions.Configuration;
using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service;

public sealed class ServiceManager : IServiceManager
{
	private readonly Lazy<ICompanyService> _companyService;
	private readonly Lazy<IEmployeeService> _employeeService;
	private readonly Lazy<IMealService> _mealService;
	private readonly Lazy<IWorkoutService> _workoutService;
	private readonly Lazy<IIngredientService> _ingredientService;
	private readonly Lazy<IAuthenticationService> _authenticationService;

	public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger,
		IMapper mapper, 
		IEmployeeLinks employeeLinks,
		UserManager<User> userManager, 
		IConfiguration configuration
		)
	{
		_companyService = new Lazy<ICompanyService>(() =>
			new CompanyService(repositoryManager, logger, mapper));
		_employeeService = new Lazy<IEmployeeService>(() =>
			new EmployeeService(repositoryManager, logger, mapper, employeeLinks));
		_mealService = new Lazy<IMealService>(() =>
			new MealService(repositoryManager, logger, mapper));
		_ingredientService = new Lazy<IIngredientService>(() =>
			new IngredientService(repositoryManager, logger, mapper));
		_workoutService = new Lazy<IWorkoutService>(() =>
			new WorkoutService(repositoryManager, logger, mapper));




		_authenticationService = new Lazy<IAuthenticationService>(() => new AuthenticationService(logger, mapper, userManager, configuration));
	}

	public ICompanyService CompanyService => _companyService.Value;
	public IEmployeeService EmployeeService => _employeeService.Value;
	public IMealService MealService => _mealService.Value;
	public IIngredientService IngredientService => _ingredientService.Value;
	public IWorkoutService WorkoutService => _workoutService.Value;
	public IAuthenticationService AuthenticationService => _authenticationService.Value;
}
