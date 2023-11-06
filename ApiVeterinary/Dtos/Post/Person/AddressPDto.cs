using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiVeterinary.Dtos.Post.Person;

public class AddressPDto
{
    public int Id { get; set; }
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

    /* Foreign Key for Client */
    public int IdClientFk { get; set; }

    /* Foreign Key for City */
    public int IdCityFk { get; set; }

}
