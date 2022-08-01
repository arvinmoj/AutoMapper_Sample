namespace Server.Models
{
	public class Person : object
	{
		public Person() : base()
		{
		}

		public System.Guid Id { get; set; }

		public int Age { get; set; }

		public string FullName { get; set; }

		public string GetInformation()
		{
			string message =
				$"Type: { base.ToString() } - Id: { Id } - Full Name: { FullName } - Age: { Age }";

			return message;
		}
	}
}
