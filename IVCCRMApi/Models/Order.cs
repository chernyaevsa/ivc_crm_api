namespace IVCCRMApi.Models
{
	public class Order
	{
		public int Id { get; set; }
		public string Theme { get; set; } = string.Empty;
		public string Text { get; set; } = string.Empty;
		public string Photo { get; set; } = string.Empty;
		public int EmployeeId { get; set; }
		public Employee? Employee { get; set; }
		public int UserId { get; set; }
		public User? User { get; set; }
		public int EquipmentStatusId { get; set; }
		public EquipmentStatus? EquipmentStatus { get; set; }
		public DateTime DateTime { get; set; }
		public int Status { get; set; }
	}
}
