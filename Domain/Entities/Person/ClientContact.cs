using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities.Person;

public class ClientContact : BaseEntity
{
    [Required]
    public string Number { get; set; }

    /* --------- Foreign Keys ---------- */

    /* Foreign Key for Client */

    [Required]
    public int IdClientFk { get; set; }
    public Client Client { get; set; }

    /* --------------------------------- */
}
