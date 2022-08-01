namespace Server.ViewModels
{
	public class PersonViewModel : object
	{
		public PersonViewModel() : base()
		{
		}

		public System.Guid Id { get; set; }

		public int Age { get; set; }

		public string FullName { get; set; }

		public string DisplayFullName { get; set; }

		public string GetInformation()
		{
			string message =
				$"Type: { base.ToString() } - Id: { Id } -" +
				$" Full Name: { FullName } - Age: { Age } -" +
				$" Display Full Name: { DisplayFullName }";

			return message;
		}
	}
}
