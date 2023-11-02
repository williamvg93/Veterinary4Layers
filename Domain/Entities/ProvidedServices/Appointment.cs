using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities.Person;
using Domain.Entities.Pet;

namespace Domain.Entities.ProvidedServices;

public class Appointment : BaseEntity
{
    [Required]
    public DateTime Date { get; set; }
    public TimeSpan Time { get; set; }

    /* --------- Foreign Keys ---------- */

    /* Foreign Key for Client */
    [Required]
    public int IdClientFk { get; set; }
    public Client Client { get; set; }
    /* Foreign Key for Pet */
    [Required]
    public int IdPetFk { get; set; }
    public CPet Pet { get; set; }
    /* Foreign Key for Service */
    [Required]
    public int IdServiceFk { get; set; }
    public Service Service { get; set; }

    /* --------------------------------- */
}
