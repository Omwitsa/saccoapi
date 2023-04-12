namespace SaccoApi.Models
{
    public class LoanBal
    {
        public string LoanNo { get; set; }
        public string LoanCode { get; set; }
        public string MemberNo { get; set; }
        public DateTime FirstDate { get; set; }
        public DateTime LastDate { get; set; }
    }
}