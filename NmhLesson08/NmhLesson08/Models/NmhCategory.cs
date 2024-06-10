using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // Ensure you include this namespace for data annotations
using System.Linq;
using System.Web;

namespace NmhLesson08.Models
{
    public class NmhCategory
    {
        [Key] // Corrected attribute
        public int NmhCategoryId { get; set; }

        // Changed type to string to better represent a category name
        public string NmhCategoryName { get; set; }

        // Thuộc tính điều hướng (navigation properties, if needed)

        public virtual ICollection<NmhBook> NmhBooks { get; set; }

    }
}
