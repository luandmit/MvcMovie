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
        public string Title { get; set; }

        [Display(Name = "Release Date")]//Đổi tên cột
        [DataType(DataType.Date)]//Định dạng kiểu dữ liệu lưu trữ
        public DateTime ReleaseDate { get; set; }
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]//Định dạng kiểu dữ liệu nhập vào

        public string Genre { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public string Rating { get; set; }
    }
}
