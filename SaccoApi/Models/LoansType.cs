using System.ComponentModel.DataAnnotations;

namespace SaccoApi.Models
{
    public class LoansType
    {
        [Key]
        public string LoanCode { get; set; }
        public string? LoanType { get; set; }
        public string LoanAcc { get; set; }
        public string? InterestAcc { get; set; }
        public string PenaltyAcc { get; set; }
        public string? SchemeCode { get; set; }
        public int? RepayPeriod { get; set; }
        public decimal? Interest { get; set; }
        public decimal? MaxAmount { get; set; }
        public string? Guarantor { get; set; }
        public string? AuditID { get; set; }
        public DateTime? AuditTime { get; set; }
        public bool? useintRange { get; set; }
        public string? accno { get; set; }
        public string? IntAccno { get; set; }
        public decimal? EarningRation { get; set; }
        public bool Penalty { get; set; }
        public string? DefaultLoanno { get; set; }
        public decimal? NSSF { get; set; }
        public decimal? bankloan { get; set; }
        public decimal? OtherDeduct { get; set; }
        public int? priority { get; set; }
        public string contraAccount { get; set; }
        public bool Bridging { get; set; }
        public string? ContraAcc { get; set; }
        public int MaxLoans { get; set; }
        public string? Repaymethod { get; set; }
        public string? PremiumAcc { get; set; }
        public string? PremiumContraAcc { get; set; }
        public double? Bridgefees { get; set; }
        public int? periodrepaid { get; set; }
        public string? WaitingPeriod { get; set; }
        public long ID { get; set; }
        public string AccruedAcc { get; set; }
        public string PPAcc { get; set; }
        public string intrecovery { get; set; }
        public bool isMain { get; set; }
        public bool selfGuarantee { get; set; }
        public string ReceivableAcc { get; set; }
        public string? loanoverpaidAcc { get; set; }
    }
}