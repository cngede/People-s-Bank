using System.ComponentModel.DataAnnotations;



namespace OnlineBank.Models
{
    public class Statement
    {
        public int? StatementId { get; set; }
        public int? AccountId { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        public DateTime StartDate { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        public DateTime EndDate { get; set; }
        public List<Statemomentum>? StatementList { get; set; }
    }
    public class Statemomentum
    {
       public int? StatemomentumId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime TranDate { get; set; }
        public float Amount { get; set; }
        public string? TranType { get; set; }
    }
}
