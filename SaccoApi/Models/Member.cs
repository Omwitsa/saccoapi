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
    }
}
