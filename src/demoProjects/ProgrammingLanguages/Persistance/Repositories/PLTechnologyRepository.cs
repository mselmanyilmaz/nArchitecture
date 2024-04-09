using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories
{
    public class PLTechnologyRepository : EfRepositoryBase<PLTechnology, BaseDbContext>, IPLTechnologyRepository
    {
        public PLTechnologyRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
