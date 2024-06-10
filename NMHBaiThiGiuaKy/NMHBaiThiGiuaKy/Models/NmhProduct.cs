using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NMHBaiThiGiuaKy.Models
{
    public class NmhProduct
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên là bắt buộc")]
        [RegularExpression(@"^[A-Z\s]+$", ErrorMessage = "Tên phải chứa chỉ các ký tự viết hoa và khoảng trắng")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Tên phải có từ 5 đến 100 ký tự")]
        public string NMHName { get; set; }

        public string NMHImage { get; set; }

        [Required(ErrorMessage = "Số lượng là bắt buộc")]
        [Range(1, 100, ErrorMessage = "Số lượng phải từ 1 đến 100")]
        public int NMHQuantity { get; set; }

        [Required(ErrorMessage = "Giá là bắt buộc")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Giá phải lớn hơn 0")]
        public decimal NMHPrice { get; set; }

        public bool NMHIsActive { get; set; }
    }
}