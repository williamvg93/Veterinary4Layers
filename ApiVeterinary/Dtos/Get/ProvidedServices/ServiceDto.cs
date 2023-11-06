using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiVeterinary.Dtos.Get.ProvidedServices;

public class ServiceDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

}
