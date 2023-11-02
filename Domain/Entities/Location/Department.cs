using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities.Location;

public class Department
{
    public string Name { get; set; }

    /* --------- Foreign Keys ---------- */

    /* Foreign Key for Country */
    public int IdCountryFk { get; set; }
    public Country Country { get; set; }
    /* --------------------------------- */

    /*    Relationship whit City -> One to Many    */
    public ICollection<City> Cities { get; set; }
    /* --------------------------------------------- */
}
