
namespace OnlineBank.Models
{
    public class Transfer
    {
        public int? TransferId { get; set; }
        public int? AccountId { get; set; }
        public int? Customerid { get; set; }
        public float Amount { get; set; }
        public string? TimeStamp { get; set; }
    }
}