using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities.ProvidedServices;

namespace Domain.Interfaces.ProvidedService;

public interface IServiceRepo : IGenericRepository<Service>
{

}