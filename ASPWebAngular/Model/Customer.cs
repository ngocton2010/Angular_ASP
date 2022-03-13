using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPWebAngular.Model
{
    public class Customer
    {
        [Key]
        public int MaKh { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string TenKh { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string Diachi { get; set; }
        [Column(TypeName = "varchar(12)")]
        public string Sodienthoai { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string LoaiKH { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Email { get; set; }
    }
}
