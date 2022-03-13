using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPWebAngular.Model
{
    public class Product
    {   [Key]
        public int MaSP { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string TenSP { get; set; }
        [Column(TypeName = "int")]
        public int Soluong { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string NhaCC { get; set; }
        [Column(TypeName = "DateTime")]
        public DateTime NgayNhanHang { get; set; }
    }
}
