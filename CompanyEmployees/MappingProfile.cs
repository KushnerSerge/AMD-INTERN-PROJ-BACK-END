using AutoMapper;
using Entities.Models;
using Shared.DataTransferObjects;

namespace CompanyEmployees;

public class MappingProfile : Profile
{
	public MappingProfile()
	{
		CreateMap<Company, CompanyDto>()
			.ForMember(c => c.FullAddress,
				opt => opt.MapFrom(x => string.Join(' ', x.Address, x.Country)));

		CreateMap<Employee, EmployeeDto>();

		CreateMap<CompanyForCreationDto, Company>();

		CreateMap<EmployeeForCreationDto, Employee>();

		CreateMap<EmployeeForUpdateDto, Employee>().ReverseMap();

		CreateMap<CompanyForUpdateDto, Company>();
		CreateMap<UserForRegistrationDto, User>();

		CreateMap<Meal, MealDto>();
		// CreateMap<Ingredient, IngredientDto>();

		CreateMap<MealForCreationDto, Meal>();
		CreateMap<IngredientForCreationDto, Ingredient>();

		CreateMap<MealForUpdateDto, Meal>();


		CreateMap<Workout, WorkoutDto>();
		CreateMap<WorkoutForCreationDto, Workout>();
		CreateMap<WorkoutForUpdateDto, Workout>().ReverseMap();
		CreateMap<StrengthForCreationDto, Strength>();
		CreateMap<EnduranceForCreationDto, Endurance>();

	}
}
