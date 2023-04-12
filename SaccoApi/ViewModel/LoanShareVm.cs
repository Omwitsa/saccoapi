using SaccoApi.Models;

namespace SaccoApi.ViewModel
{
    public class LoanShareVm
    {
        public string? MemberNo { get; set; }
        public string? LoanShareType { get; set; }
        public string? Amount { get; set; }
        public string? Date { get; set; }
        public string? AuditID { get; set; }
        public TransType? TransType { get; set; }
    }
    
    public enum TransType
    {
        LoansRepay = 1,
        SharesContrib = 2
    }
}
