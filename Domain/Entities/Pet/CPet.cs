using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities.Person;
using Domain.Entities.ProvidedServices;

namespace Domain.Entities.Pet;

public class CPet : BaseEntity
{
    [Required]
    public string Name { get; set; }
    [Required]
    public string Species { get; set; }

    public DateTime BirthDate { get; set; }


    /* --------- Foreign Keys ---------- */

    /* Foreign Key for Cliente */
    [Required]
    public int IdClientFk { get; set; }
    public Client Client { get; set; }
    /* Foreign Key for PetBred */
    [Required]
    public int IdPetBredFk { get; set; }
    public PetBred PetBred { get; set; }

    /* --------------------------------- */

    /* Relationship whit Contacts -> One to Many */
    public ICollection<Appointment> Appointments { get; set; }
    /* --------------------------------- */
}
