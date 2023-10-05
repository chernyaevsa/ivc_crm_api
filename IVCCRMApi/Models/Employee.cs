namespace IVCCRMApi.Models
{
	public class Employee
	{
		public int Id { get; set; }	
		public string Surname { get; set; } = string.Empty;
		public string Name { get; set; } = string.Empty;
		public string Patronymic { get; set; } = string.Empty;
		public string Function { get; set; } = string.Empty;
		public string Photo { get; set; } = string.Empty;
		public List<Order>? Orders { get; set; }
		public List<EquipmentStatus>? EquipmentStatuses { get; set; }
	}
}
