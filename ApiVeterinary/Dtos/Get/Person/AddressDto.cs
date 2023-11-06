using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiVeterinary.Dtos.Get.Person;

public class AddressDto
{
    public int Id { get; set; }
    public string TypeRoad { get; set; }
    public int FirstNumber { get; set; }
    public string FirstLetter { get; set; }
    public string Complement { get; set; }
    public string PostalCode { get; set; }
}
