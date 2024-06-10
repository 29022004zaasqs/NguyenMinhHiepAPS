using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // Ensure you include this namespace for data annotations
using System.Linq;
using System.Web;

namespace NmhLesson08.Models
{
    public class NmhBook
    {
        [Key] // Corrected attribute
        public int NmhBookId { get; set; }
        public string NmhTitle { get; set; }
        public string NmhAuthor { get; set; }
        public int NmhYear { get; set; }
        public string NmhPublisher { get; set; }
        public string NmhPicture { get; set; }
        public int NmhCategoryId { get; set; }

        // thuộc tính quan hệ (navigation property)
        public virtual NmhCategory NmhCategory { get; set; }
    }
}
