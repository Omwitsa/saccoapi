using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SaccoApi.Models;
using SaccoApi.ViewModel;
using System.Diagnostics.Metrics;

namespace SaccoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionController : Controller
    {
        private readonly SaccoApiContext _context;

        public TransactionController(SaccoApiContext context)
        {
            _context = context;
        }

        [Route("getLoanShareTypes")]
        [HttpGet]
        public async Task<ReturnData> GetLoanShareTypes()
        {
            try
            {
                var loanTypes = await _context.LOANTYPE.Select(x => x.LoanType).ToListAsync();
                var shareTypes = await _context.sharetype.Select(x => x.SharesType).ToListAsync();

                return new ReturnData
                {
                    Success = true,
                    Data = new
                    {
                        loanTypes,
                        shareTypes
                    }
                };
            }
            catch (Exception)
            {

                return new ReturnData
                {
                    Success = false,
                    Message = "Sorry, An error occurred"
                };
            }
        }

        [Route("payments")]
        [HttpPost]
        public async Task<ReturnData> Payments([FromBody] List<LoanShareVm> loanShares)
        {
            try
            {
                var loans = loanShares.Where(p => p.TransType == TransType.LoansRepay).ToList();
                var shares = loanShares.Where(p => p.TransType == TransType.SharesContrib).ToList();
                SaveLoans(loans);
                SaveShares(shares);

                return new ReturnData
                {
                    Success = true,
                    Message = "Payments received successfully",
                    Data = ""
                };
            }
            catch (Exception)
            {
                return new ReturnData
                {
                    Success = false,
                    Message = "Sorry, An error occurred",
                    Data = ""
                };
            }
        }

        private void SaveLoans(List<LoanShareVm> loans)
        {
            var repays = new List<Repay>();
            var glTransactions = new List<GlTransaction>();
            
            loans.ForEach(l =>
            {
                l.MemberNo = l?.MemberNo ?? "";
                l.LoanShareType = l?.LoanShareType ?? "";
                int.TryParse(l.MemberNo, out int memberNo);
                var member = _context.MEMBERS.FirstOrDefault(m => m.MemberNo == memberNo);
                var loanType = _context.LOANTYPE.FirstOrDefault(t => t.LoanType.ToUpper().Equals(l.LoanShareType.ToUpper()));
                var loanCode = loanType?.LoanCode ?? "";
                var loanBal = _context.LOANBAL.FirstOrDefault(b => b.MemberNo.ToUpper().Equals(l.MemberNo.ToUpper())  
                && b.LoanCode.ToUpper().Equals(loanCode.ToUpper()) && b.FirstDate <= DateTime.Today && b.LastDate >= DateTime.Today);
                // MemberNo, Amount, Date, AuditID
                decimal.TryParse(l.Amount, out decimal amount);
                var transDate = Convert.ToDateTime(l.Date);
                repays.Add(new Repay
                {
                    LoanNo = loanBal.LoanNo,
                    DateReceived = transDate.Date,
                    PaymentNo = memberNo,
                    Amount = amount,
                    Principal = amount,
                    Interest = 0,
                    IntrCharged = 0,
                    IntrOwed = 0,
                    IntrAccrued = null,
                    Penalty = 0,
                    LoanBalance = 0,
                    ReceiptNo = "SYNCH",
                    chequeno = null,
                    Locked = null,
                    Posted = null,
                    Accrued = null,
                    Remarks = "Loan Repayment Rcpt("+ member.Surname + ")",
                    AuditID = l.AuditID,
                    nextduedate = null,
                    AuditTime = DateTime.Now,
                    Transby = l.AuditID,
                    IntBalance = 0,
                    Loancode = null,
                    Interestaccrued = null,
                    MRNo = null,
                    MRCleared = null,
                    Transno = null,
                    TransDate = transDate.Date,
                    BridgeInterest = null,
                    BrgLoan = null,
                    Statementdate = null,
                    LoanAcc = null,
                    InterestAcc = null,
                    ContraAcc = null,
                    Cash = null,
                    CashBookDate = null,
                    dregard = 0,
                    offs = 0,
                    TransactionNo = l.AuditID + "" + DateTime.Now,
                });

                glTransactions.Add(new GlTransaction
                {
                    TransDate = transDate.Date,
                    Amount = amount,
                    DrAccNo = "601001",
                    CrAccNo = loanType?.LoanAcc ?? "",
                    Temp = "",
                    DocumentNo = "SYNCH",
                    Source = l.MemberNo,
                    TransDescript = "Loan Repayment Rcpt(" + member.Surname + ")",
                    AuditTime = DateTime.Now,
                    AuditID = l.AuditID,
                    Cash = 1,
                    doc_posted = 1,
                    ChequeNo = "SYNCH",
                    dregard = false,
                    Recon = null,
                    TransactionNo = l.AuditID + "" + DateTime.Now,
                    Module = "",
                    ReconId = 0
                });
            });

            if (repays.Any())
            {
                _context.REPAY.AddRange(repays);
                _context.GLTRANSACTIONS.AddRange(glTransactions);
                _context.SaveChanges();
            }
        }

        private void SaveShares(List<LoanShareVm> shares)
        {
            var contribs = new List<Contrib>();
            var glTransactions = new List<GlTransaction>();
            shares.ForEach(s =>
            {
                int.TryParse(s.MemberNo, out int memberNo);
                var shareType = _context.sharetype.FirstOrDefault(t => t.SharesType.ToUpper().Equals(s.LoanShareType.ToUpper()));
                var member = _context.MEMBERS.FirstOrDefault(m => m.MemberNo == memberNo);
                decimal.TryParse(s.Amount, out decimal amount);
                var transDate = Convert.ToDateTime(s.Date);

                contribs.Add(new Contrib
                {
                    MemberNo = s.MemberNo,
                    ContrDate = transDate.Date,
                    RefNo = 0,
                    Amount = amount,
                    ShareBal = amount,
                    TransBy = s.AuditID,
                    ChequeNo = "Cash",
                    ReceiptNo = "SYNCH",
                    Locked = null,
                    Posted = null,
                    Remarks = "MEMBER  RECEIPT",
                    AuditID = s.AuditID,
                    AuditTime = DateTime.Now,
                    schemecode = null,
                    TransferDesc = null,
                    MrCleared = null,
                    mrno = null,
                    TransNo = "",
                    Offset = false,
                    TransDate = null,
                    SharesAcc = null,
                    ContraAcc = null,
                    CashBookdate = null,
                    dregard = null,
                    offs = null,
                    sharescode = shareType.SharesCode,
                    TransactionNo = s.AuditID + "" + DateTime.Now,
                    Glamount = null,
                    year = transDate.Month < 3 ? transDate.Year - 1 : transDate.Year,
                    Closed = 0
                });

                glTransactions.Add(new GlTransaction
                {
                    TransDate = transDate.Date,
                    Amount = amount,
                    DrAccNo = "601001",
                    CrAccNo = shareType?.SharesAcc ?? "",
                    Temp = "",
                    DocumentNo = "SYNCH",
                    Source = s.MemberNo,
                    TransDescript = "MEMBER  RECEIPT",
                    AuditTime = DateTime.Now,
                    AuditID = s.AuditID,
                    Cash = 1,
                    doc_posted = 1,
                    ChequeNo = "SYNCH",
                    dregard = false,
                    Recon = null,
                    TransactionNo = s.AuditID + "" + DateTime.Now,
                    Module = "",
                    ReconId = 0
                });
            });

            if (contribs.Any())
            {
                _context.CONTRIB.AddRange(contribs);
                _context.GLTRANSACTIONS.AddRange(glTransactions);
                _context.SaveChanges();
            }
        }
    }
}
