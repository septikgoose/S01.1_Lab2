using System.ComponentModel.DataAnnotations;

namespace ZombieParty.Models
{
    public class ZombieType
    {

        public int Id { get; set; }

        [Required]
        [Display(Name = "Type Name")]
        //[ValidationResult("Type Name has to be filled")]
        public string TypeName { get; set; }

    }
}

