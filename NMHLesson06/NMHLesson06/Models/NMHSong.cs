using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NMHLesson06.Models
{
    public class NMHSong
    {
        internal int id;

        public int ID { get; set; }
        [DisplayName("Tiêu đề")]
        [Required(ErrorMessage = "NMH:Hãy nhập trường này!!!")]
        public string NMHTitle { get; set; }
        [DisplayName("tác giả")]
        [Required(ErrorMessage = "NMH: Hãy nhập tên tác giá ")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "NMHH: Độ dài trong khoảng [2-20]")]
        public string NMHAuthor { get; set; }
        [DisplayName("Nghệ sĩ")]
        [Required(ErrorMessage = "NMH: Hãy nhập năm nghệ sĩ")]
        public string NMHArtist { get; set; }
        [DisplayName("Năm xuất bản")]
        [Required(ErrorMessage = "NMH: Hãy nhập năm xuất bản")]
        [RegularExpression(@"[0-9]{4}", ErrorMessage = "NMH: Hãy nhập 4 ký tự từ số")]
        [Range(1900, 2016, ErrorMessage = "NMH: Hãy nhập giá trị trong khoảng [1900-2016]")]
        public int NMHYearRelease { get; set; }
    }
}
