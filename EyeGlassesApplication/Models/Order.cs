using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Order
{
	[Key]
	public int OrderID { get; set; }

	[Required]
	[ForeignKey("User")]
	public int UserID { get; set; }

	[Required]
	public DateTime OrderDate { get; set; }

	[Required]
	[MaxLength(50)]
	public string Status { get; set; }

	[Required]
	[Column(TypeName = "decimal(10, 2)")]
	public decimal TotalAmount { get; set; }

	public User User { get; set; }

	public ICollection<Order_Details> OrderDetails { get; set; }
	public ICollection<Payment> Payments { get; set; }

	public Order()
	{
		OrderDate = DateTime.Now;
		Status = "Pending";
		OrderDetails = new List<Order_Details>();
		Payments = new List<Payment>();
	}
}