using System.ComponentModel.DataAnnotations;

namespace SaccoApi.Models
{
    public class ShareType
    {
        [Key]
        public string SharesCode { get; set; }
        public string? SharesType { get; set; }
        public string SharesAcc { get; set; }
        public int? PlacePeriod { get; set; }
        public int? Issharecapital { get; set; }
        public decimal? Interest { get; set; }
        public decimal? MaxAmount { get; set; }
        public string? Guarantor { get; set; }
        public string? AuditID { get; set; }
        public DateTime? AuditTime { get; set; }
        public string? accno { get; set; }
        public string? shareboost { get; set; }
        public bool IsMainShares { get; set; }
        public bool UsedToGuarantee { get; set; }
        public string? ContraAcc { get; set; }
        public bool UsedToOffset { get; set; }
        public bool Withdrawable { get; set; }
        public bool loanquaranto { get; set; }
        public int Priority { get; set; }
        public decimal MinAmount { get; set; }
        public string PPAcc { get; set; }
        public decimal LowerLimit { get; set; }
        public decimal ElseRatio { get; set; }
    }
}