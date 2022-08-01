namespace Server.AutoMapperProfiles
{
	public class PersonProfile : AutoMapper.Profile
	{
		public PersonProfile() : base()
		{
			//CreateMap<ViewModels.PersonViewModel, Models.Person>();
			//CreateMap<Models.Person, ViewModels.PersonViewModel>();

			CreateMap<ViewModels.PersonViewModel, Models.Person>();
			CreateMap<Models.Person, ViewModels.PersonViewModel>()
				.ForMember(dest => dest.DisplayFullName,
				opt => opt.MapFrom(src => $"I'm { src.FullName } and { src.Age } years old."));
		}
	}
}
