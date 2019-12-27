using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace eCommerce_Mvc.Entities.DTO
{
    public class CategoryDTO
    {
        public int Id { get; set; }

        [Display(Name = "KATEGORI ADI")]
        [Required(ErrorMessage = "BU ALAN ZORUNLUDUR")]
        [MinLength(5, ErrorMessage = "{0} uzunluğu en az {1} karakter olmalıdır!")]
        public string Name { get; set; }

        [Display(Name = "KATEGORI AÇIKLAMA")]
        [Required(ErrorMessage = "BU ALAN ZORUNLUDUR")]
        [MinLength(5, ErrorMessage = "{0} uzunluğu en az {1} karakter olmalıdır!")]
        [AllowHtml]
        public string Description { get; set; }
    }
}
