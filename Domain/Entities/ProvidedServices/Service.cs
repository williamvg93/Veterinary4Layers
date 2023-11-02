using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities.ProvidedServices;

public class Service : BaseEntity
{
    [Required]
    public string Name { get; set; }
    public double Price { get; set; }

    /* Relationship whit Appointments -> One to Many */
    public ICollection<Appointment> Appointments { get; set; }

}
