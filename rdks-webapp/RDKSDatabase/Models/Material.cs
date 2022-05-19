using System.ComponentModel.DataAnnotations;

namespace RDKSDatabase.Models
{
    public class Material
    {
        [Key]
        [Display(Name ="Material Code")]
        public int MaterialCode { get; set; }

        [Required]
        [Display(Name ="Material Type")]
        public string MaterialType { get; set; }
    }
}
