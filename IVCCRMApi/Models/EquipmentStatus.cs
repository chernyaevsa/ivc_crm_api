namespace IVCCRMApi.Models
{
	public class EquipmentStatus
	{
		public int Id { get; set; }
		public int EquipmentId { get; set; }
		public Equipment? Equipment { get; set; }
		public int ClassroomId { get; set; }
		public Classroom? Classroom { get; set; }
		public int EmployeeId { get; set; }
		public Employee? Employee { get; set; }
		public int Status { get; set; } 
		public DateTime DateTime { get; set; }
		public string Reason { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public List<Order>? Orders { get; set; }
	}
}
