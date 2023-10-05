namespace IVCCRMApi.Models
{
	public class Equipment
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		/// <summary>
		/// Инвентарный номер. Пример: ВА0000000236, 4.0000127, 467432423758
		/// </summary>
		public string InvNumber { get; set; } = string.Empty;
		public int Count { get; set; }
		public DateTime Date { get; set; }
		public float Price { get; set; }
		public string Photo { get; set;} = string.Empty;
		public List<EquipmentStatus>? Statuses { get; set; }
	}
}
