using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPWebAngular.Model
{
    public class Manufacture
    {
        [Key]
        public int MaNCC { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string TenNCC { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string Diachi { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Sodienthoai { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string Email { get; set; }
    }
}
