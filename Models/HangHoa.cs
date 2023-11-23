using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DuongThiHang_211211501.Models
{
    public partial class HangHoa
    {
        /*[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]*/
        public int MaHang { get; set; }
        public int MaLoai { get; set; }
        public string TenHang { get; set; } = null!;
        [Required(ErrorMessage = "Giá không được để trống")]
        [Range(100, 5000, ErrorMessage = "Giá phải nằm trong khoảng 100 đến 5000")]
        public decimal? Gia { get; set; }
        [Required(ErrorMessage = "Tên file ảnh không được để trống")]
        [FileExtensions(Extensions = "jpg,png,gif,tiff", ErrorMessage = "Định dạng file ảnh không hợp lệ")]
        public string? Anh { get; set; }

        public virtual LoaiHang MaLoaiNavigation { get; set; } = null!;
    }
}
