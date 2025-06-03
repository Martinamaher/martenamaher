namespace EyeGlassesApplication.Models
{
	public class AdminAdminRole
	{
		public int AdminID { get; set; }
		public Admin Admin { get; set; }

		public int AdminRoleID { get; set; }
		public AdminRole AdminRole { get; set; }
	}
}
