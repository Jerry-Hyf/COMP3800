using System.ComponentModel.DataAnnotations;

namespace RDKSDatabase.Models
{
    public class WasteSource
    {
        [Key]
        public string? WasteGenerator { get; set; }

        [Required]
        public string? WasteSourceSiteAddress { get; set; }

        public ICollection<Permit>? Permits { get; set; }

    }
}
