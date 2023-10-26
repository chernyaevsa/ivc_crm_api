namespace IVCCRMApi.Models
{
	public class Classroom
	{
		public int Id { get; set; }
		public int BranchId { get; set; }
		public Branch? Branch { get; set; }
		public string Number { get; set; } = "";
		public string Name { get; set; } = "";
	}
}
