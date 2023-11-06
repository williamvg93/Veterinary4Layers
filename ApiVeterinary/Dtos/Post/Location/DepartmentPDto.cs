using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiVeterinary.Dtos.Post.Location;

public class DepartmentPDto
{
    public int Id { get; set; }
    public string Name { get; set; }

    /* Foreign Key for Country */
    public int IdCountryFk { get; set; }

}
