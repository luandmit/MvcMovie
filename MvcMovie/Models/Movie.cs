using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [Display(Name = "Release Date")]//Đổi tên cột
        [DataType(DataType.Date)]//Định dạng kiểu dữ liệu lưu trữ
        //[Range(typeof(DateTime), "1/1/1966", "1/1/2020")]//Chú ý: Xác thực jQuery không hoạt động với thuộc tính Range và DateTime. Ví dụ: mã sau sẽ luôn hiển thị lỗi xác thực phía ứng dụng, ngay cả khi ngày nằm trong phạm vi được chỉ định:
        public DateTime ReleaseDate { get; set; }
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]//Định dạng kiểu dữ liệu nhập vào

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public string Rating { get; set; }
    }
}
