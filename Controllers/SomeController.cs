namespace Server.Controllers
{
	[Microsoft.AspNetCore.Mvc.ApiController]
	[Microsoft.AspNetCore.Mvc.Route("[controller]")]
	public class SomeController : Microsoft.AspNetCore.Mvc.Controller
	{
		public SomeController(AutoMapper.IMapper mapper) : base()
		{
			Mapper = mapper;
		}

		protected AutoMapper.IMapper Mapper { get; }

		[Microsoft.AspNetCore.Mvc.HttpGet]
		public Microsoft.AspNetCore.Mvc.IActionResult Get()
		{
			Models.Person person =
				new Models.Person
				{
					Id =
						System.Guid.NewGuid(),

					Age = 20,
					FullName = "Ali Reza Alavi",
				};

			ViewModels.PersonViewModel personViewModel =
				Mapper.Map<ViewModels.PersonViewModel>(source: person);

			string message =
				personViewModel.GetInformation();

			return Ok(value: message);
		}
	}
}
