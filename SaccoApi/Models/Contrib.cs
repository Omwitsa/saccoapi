namespace SaccoApi.Models
{
    public class Contrib
    {
        public long ID { get; set; }
        public string MemberNo { get; set; }
        public DateTime? ContrDate { get; set; }
        public long? RefNo { get; set; }
        public decimal? Amount { get; set; }
        public decimal? ShareBal { get; set; }
        public string? TransBy { get; set; }
        public string? ChequeNo { get; set; }
        public string? ReceiptNo { get; set; }
        public string? Locked { get; set; }
        public string? Posted { get; set; }
        public string? Remarks { get; set; }
        public string? AuditID { get; set; }
        public DateTime? AuditTime { get; set; }
        public string? schemecode { get; set; }
        public string? TransferDesc { get; set; }
        public string? MrCleared { get; set; }
        public string? mrno { get; set; }
        public string TransNo { get; set; }
        public bool Offset { get; set; }
        public DateTime? TransDate { get; set; }
        public string? SharesAcc { get; set; }
        public string? ContraAcc { get; set; }
        public DateTime? CashBookdate { get; set; }
        public int? dregard { get; set; }
        public int? offs { get; set; }
        public string? sharescode { get; set; }
        public string? TransactionNo { get; set; }
        public decimal? Glamount { get; set; }
        public int year { get; set; }
        public int? Closed { get; set; }
    }
}