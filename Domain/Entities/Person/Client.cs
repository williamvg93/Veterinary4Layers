using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities.Pet;
using Domain.Entities.ProvidedServices;

namespace Domain.Entities.Person;

public class Client : BaseEntity
{
    [Required]
    public string Name { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public string Email { get; set; }

    /* --------- Foreign Keys ---------- */

    /* Relationship whit Addresses -> One to One */
    public Address Address { get; set; }

    /* Relationship whit Contacts -> One to Many */
    public ICollection<ClientContact> ClientContacts { get; set; }
    /* Relationship whit Pets -> One to Many */
    public ICollection<CPet> Pets { get; set; }
    /* Relationship whit Appointments -> One to Many */
    public ICollection<Appointment> Appointments { get; set; }

}
