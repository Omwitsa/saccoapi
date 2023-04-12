using System.ComponentModel.DataAnnotations;

namespace SaccoApi.Models
{
    public class Member
    {
        [Key]
        public long MemberNo { get; set; }
        public string? StaffNo { get; set; }
        public string? IDNo { get; set; }
        public string? Surname { get; set; }
        public string? OtherNames { get; set; }
        public string? Sex { get; set; }
        public DateTime? DOB { get; set; }
        public string? Employer { get; set; }
        public string? Dept { get; set; }
        public string? Rank { get; set; }
        public string? Terms { get; set; }
        public string? PresentAddr { get; set; }
        public string? OfficeTelNo { get; set; }
        public string? HomeAddr { get; set; }
        public string? HomeTelNo { get; set; }
        public decimal? RegFee { get; set; }
        public decimal? InitShares { get; set; }
        public DateTime? AsAtDate { get; set; }
        public double? MonthlyContr { get; set; }
        public DateTime? ApplicDate { get; set; }
        public DateTime? EffectDate { get; set; }
        public string? Signed { get; set; }
        public string? Accepted { get; set; }
        public bool? Archived { get; set; }
        public bool? Withdrawn { get; set; }
        public string? Province { get; set; }
        public string? District { get; set; }
        public string? Station { get; set; }
        public string? CompanyCode { get; set; }
        public string? PIN { get; set; }
        public string? Photo { get; set; }
        public decimal? ShareCap { get; set; }
        public string? BankCode { get; set; }
        public string? Bname { get; set; }
        public string? AuditID { get; set; }
        public DateTime? AuditTime { get; set; }
        public DateTime? E_DATE { get; set; }
        public string? posted { get; set; }
        public decimal? initsharesTransfered { get; set; }
        public DateTime? Transferdate { get; set; }
        public decimal? LoanBalance { get; set; }
        public decimal? InterestBalance { get; set; }
        public string? EmailAddress { get; set; }
        public string? accno { get; set; }
        public DateTime? memberwitrawaldate { get; set; }
        public int? Dormant { get; set; }
        public string? MemberDescription { get; set; }
        public string? email { get; set; }
        public string? TransactionNo { get; set; }
        public bool? Entrance { get; set; }
        public short? status { get; set; }
        public bool? mstatus { get; set; }
        public int? Age { get; set; }
        public int? Varia { get; set; }
    }
}
