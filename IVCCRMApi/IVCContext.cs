using IVCCRMApi.Models;
using Microsoft.EntityFrameworkCore;

namespace IVCCRMApi
{
	public class IVCContext : DbContext
	{
		public DbSet<Equipment> Equipments { get; set; }
		public DbSet<EquipmentStatus> EquipmentStatuses { get; set; }
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Branch> Branches { get; set; }
		public DbSet<Classroom>	Classrooms { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<User> Users { get; set; }

		public IVCContext() 
		{ 
			Database.EnsureCreated();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder.UseMySQL("Server=127.0.0.1;User=root;Database=ivccrm;"));
		}
	}
}
