﻿namespace SaccoApi.Models
{
    public class Repay
    {
        public string LoanNo { get; set; }
        public DateTime? DateReceived { get; set; }
        public int? PaymentNo { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Principal { get; set; }
        public decimal? Interest { get; set; }
        public decimal? IntrCharged { get; set; }
        public decimal? IntrOwed { get; set; }
        public decimal? IntrAccrued { get; set; }
        public decimal Penalty { get; set; }
        public decimal? LoanBalance { get; set; }
        public string? ReceiptNo { get; set; }
        public string? chequeno { get; set; }
        public bool? Locked { get; set; }
        public bool? Posted { get; set; }
        public bool? Accrued { get; set; }
        public string? Remarks { get; set; }
        public string? AuditID { get; set;}
        public DateTime? nextduedate { get; set; }
        public DateTime? AuditTime { get; set; }
        public long RepayId { get; set; }
        public string? Transby { get; set; }
        public decimal? IntBalance { get; set; }
        public string? Loancode { get; set; }
        public decimal? Interestaccrued { get; set; }
        public string? MRNo { get; set; }
        public string? MRCleared { get; set; }
        public string? Transno { get; set; }
        public DateTime? TransDate { get; set; }
        public decimal? BridgeInterest { get; set; }
        public string? BrgLoan { get; set; }
        public DateTime? Statementdate { get; set; }
        public string? LoanAcc { get; set; }
        public string? InterestAcc { get; set; }
        public string? ContraAcc { get; set; }
        public int? Cash { get; set; }
        public DateTime? CashBookDate { get; set; }
        public int? dregard { get; set; }
        public int? offs { get; set; }
        public string? TransactionNo { get; set; }
    }
}