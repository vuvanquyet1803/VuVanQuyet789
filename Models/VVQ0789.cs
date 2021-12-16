using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VuVanQuyet789.Models
{
    public class VVQ0789
    {[Key]
        [DisplayName("Số thứ tự")]
        [StringLength(20)]
        public string VVQId { get; set; }
        [StringLength(50, MinimumLength = 3)]
        [DisplayName("Tên")]
        public string VVQName { get; set; }
        
        [StringLength(50, MinimumLength = 3)]
        [DisplayName("Giới tính")]
        [Required]
        public Boolean VVQGender { get; set; }
    }
}