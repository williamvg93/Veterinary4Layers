using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities.Pet;

public class PetBred : BaseEntity
{
    [Required]
    public string Name { get; set; }


    /* Relationship whit Pets -> One to Many */
    public ICollection<CPet> Pets { get; set; }
}
