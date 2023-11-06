using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiVeterinary.Dtos.Get.Pet;

public class PetDto
{
    public int Id { get; set; }
    public string Name { get; set; }

    public string Species { get; set; }

    public DateTime BirthDate { get; set; }
}
