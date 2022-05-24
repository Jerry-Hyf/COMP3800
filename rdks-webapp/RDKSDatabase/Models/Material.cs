using System.ComponentModel.DataAnnotations;

namespace RDKSDatabase.Models
{
<<<<<<< HEAD
    /// <summary>
    /// This class represents Material Model
=======

    /// <summary>
    /// The Material class which has all the attributes of the Material table.
    /// MaterialCode is the primary key.
>>>>>>> f0465070f968104d2cf7b64353f70a2a4080a411
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
