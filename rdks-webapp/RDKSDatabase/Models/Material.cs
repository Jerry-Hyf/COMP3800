using System.ComponentModel.DataAnnotations;

namespace RDKSDatabase.Models
{
    /// <summary>
    /// This class represents Material Model
    /// </summary>
    public class Material
    {
        [Key]
        [Display(Name ="Material Code")]
        public int MaterialCode { get; set; }

        [Required]
        [Display(Name ="Material Type")]
        public string MaterialType { get; set; }

        public ICollection<Permit> Permits { get; set; }
    }
}
