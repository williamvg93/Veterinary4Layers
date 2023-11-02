using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities.Location;

namespace Domain.Entities.Person;

public class Address : BaseEntity
{
    public string TypeRoad { get; set; }
    public int FirstNumber { get; set; }
    public string FirstLetter { get; set; }
    public string Bis { get; set; }
    public string SecondLetter { get; set; }
    public string Cardinal { get; set; }
    public int SecondNumber { get; set; }
    public string ThirdLetter { get; set; }
    public int ThirdNumber { get; set; }
    public string SecondCardinal { get; set; }
    public string Complement { get; set; }
    public string PostalCode { get; set; }

    /* --------- Foreign Keys ---------- */

    /* Foreign Key for Client */
    [Required]
    public int IdClientFk { get; set; }
    public Client Client { get; set; }

    /* Foreign Key for City */

    [Required]
    public int IdCityFk { get; set; }
    public City City { get; set; }

    /* --------------------------------- */
}
