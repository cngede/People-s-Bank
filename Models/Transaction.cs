namespace OnlineBank.Models
{
  

    public class Transaction
    {
        public int? TransactionId { get; set; }
        public int? AccountId { get; set; }
        public string? Type { get; set; }
        public string? Amount { get; set; }
        public string? TimeStamp { get; set; }
    }
}
