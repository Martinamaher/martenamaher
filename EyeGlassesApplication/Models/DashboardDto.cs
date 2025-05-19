namespace eyeglassesstoreapp.Models
{
	public class DashboardDTO
	{
		public int TotalUsers { get; set; }
		public int TotalOrders { get; set; }
		public int TotalProducts { get; set; }
		public decimal TotalRevenue { get; set; }
		public List<RecentOrderDTO> RecentOrders { get; set; }
		public string TopProductName { get; set; }
		public int TopProductSales { get; set; }
	}

	public class RecentOrderDTO
	{
		public int OrderId { get; set; }
		public string CustomerName { get; set; }
		public DateTime OrderDate { get; set; }
		public decimal OrderTotal { get; set; }
	}
}
