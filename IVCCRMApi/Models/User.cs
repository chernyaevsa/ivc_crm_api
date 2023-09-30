namespace IVCCRMApi.Models
{
	public class User
	{
		public int Id { get; set; }
		public int EmployeeId { get; set; }
		public Employee? Employee { get; set; }
		public string Login { get; set; } = string.Empty;
		public string Password { get; set; } = string.Empty;
		public List<Order>? Orders { get; set; }
	}
}
