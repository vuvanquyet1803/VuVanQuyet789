using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VuVanQuyet789.Models
{
    public class CompanyVVQ789
    {[Key]
        [DisplayName("Số thứ tự")]
        [StringLength(20)]
        public string CompanyId { get; set; }
        [StringLength(50, MinimumLength = 3)]
        [DisplayName("Tên công ty")]
        public string CompanyName { get; set; }
    }
}