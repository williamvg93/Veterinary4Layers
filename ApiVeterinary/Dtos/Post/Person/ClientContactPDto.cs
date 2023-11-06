using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiVeterinary.Dtos.Post.Person;

public class ClientContactPDto
{
    public int Id { get; set; }
    public string Number { get; set; }

    /* Foreign Key for Client */
    public int IdClientFk { get; set; }
}
