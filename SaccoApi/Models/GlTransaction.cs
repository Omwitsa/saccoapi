namespace SaccoApi.Models
{
    public class GlTransaction
    {
        public long ID { get; set; }
        public DateTime TransDate { get; set; }
        public decimal Amount { get; set; }
        public string? DrAccNo { get; set; }
        public string CrAccNo { get; set; }
        public string Temp { get; set; }
        public string DocumentNo { get; set; }
        public string Source { get; set; }
        public string TransDescript { get; set; }
        public DateTime AuditTime { get; set; }
        public string AuditID { get; set; }
        public int Cash { get; set; }
        public int doc_posted { get; set; }
        public string? ChequeNo { get; set; }
        public bool? dregard { get; set; }
        public bool? Recon { get; set; }
        public string? TransactionNo { get; set; }
        public string Module { get; set; }
        public int ReconId { get; set; }
    }
}