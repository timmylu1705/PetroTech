﻿using PetroTech.Data.Infastructure;
using PetroTech.Data.IRepositories;
using PetroTech.Model.Models;

namespace PetroTech.Data.Repositories
{
    public class VisitorStatisticRepository : Repository<VisitorStatistic>, IVisitorStatisticRepository
    {
        public VisitorStatisticRepository(IDBFactory dBFactory) : base(dBFactory)
        {

        }
    }
}